#if NET6_0_OR_GREATER
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Collections.Concurrent;
using Microsoft.AspNetCore.Http;
#endif
using System.Data;
using System.Data.SqlClient;
using System;
using System.Threading.Tasks;
using System.Threading;
using ThreatLocker.Framework.Extensions;

namespace ThreatLocker.Framework.DbLogger
{
#if NET6_0_OR_GREATER
    [ProviderAlias("Database")]
    public class DbLoggerProvider : IDisposable, ILoggerProvider, ISupportExternalScope
    {
        private IExternalScopeProvider? _fScopeProvider;
        private bool _terminated;
        private ConcurrentQueue<AppLogger> _logQueue = new ConcurrentQueue<AppLogger>();
        private IConfiguration _config;
        private DbLoggerOptions _options;
        private IHttpContextAccessor _httpContextAccessor;

        public DbLoggerProvider(IOptions<DbLoggerOptions> options, IConfiguration config, IHttpContextAccessor httpContextAccessor)
        {
            _options = options.Value;
            _config = config;
            _httpContextAccessor = httpContextAccessor;

            ThreadProc();
        }
        
        public string Environment
        {
            get
            {
                try
                {
                    return _config.GetSection("AppSettings")["Environment"];
                }
                catch { }

                return string.Empty;
            }
        }

        public string ApplicationName
        {
            get
            {
                try
                {
                    return _config.GetSection("AppSettings")["ApplicationName"];
                }
                catch { }

                return string.Empty;
            }
        }

        public ILogger CreateLogger(string categoryName)
        {
            return new DbLogger(this, categoryName, _httpContextAccessor);
        }

        void ISupportExternalScope.SetScopeProvider(IExternalScopeProvider scopeProvider)
        {
            _fScopeProvider = scopeProvider;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            bool Result = logLevel != LogLevel.None
                && this._options.LogLevel != LogLevel.None
                && Convert.ToInt32(logLevel) >= Convert.ToInt32(this._options.LogLevel);

            return Result;
        }

        public void WriteLog(AppLogger logEntry)
        {
            if (logEntry != null)
            {
                _logQueue.Enqueue(logEntry);
            }
        }

        public IExternalScopeProvider ScopeProvider
        {
            get
            {
                if (_fScopeProvider == null)
                    _fScopeProvider = new LoggerExternalScopeProvider();
                return _fScopeProvider;
            }
        }

        void ThreadProc()
        {
            Task.Run(() =>
            {
                while (!_terminated)
                {
                    try
                    {
                        ProcessLogEntry();
                        Thread.Sleep(TimeSpan.FromSeconds(5));
                    }
                    catch { }
                }
            });
        }

        private static bool _processingQueue = false;

        private async Task ProcessLogEntry()
        {
            if (_processingQueue)
                return;

            _processingQueue = true;

            DataTable dtAppLogger = new DataTable();
            dtAppLogger.Columns.Add("ID", typeof(int));
            dtAppLogger.Columns.Add("AppLoggerId", typeof(Guid));
            dtAppLogger.Columns.Add("DateTime", typeof(DateTime));
            dtAppLogger.Columns.Add("LogLevel", typeof(string));
            dtAppLogger.Columns.Add("Environment", typeof(string));
            dtAppLogger.Columns.Add("ApplicationName", typeof(string));
            dtAppLogger.Columns.Add("Host", typeof(string));
            dtAppLogger.Columns.Add("Path", typeof(string));
            dtAppLogger.Columns.Add("Message", typeof(string));
            dtAppLogger.Columns.Add("StackTrace", typeof(string));
            dtAppLogger.Columns.Add("Username", typeof(string));
            dtAppLogger.Columns.Add("Query", typeof(string));
            dtAppLogger.Columns.Add("Headers", typeof(string));
            dtAppLogger.Columns.Add("UserAgent", typeof(string));
            dtAppLogger.Columns.Add("TraceIdentifier", typeof(string));
            dtAppLogger.Columns.Add("Scopes", typeof(string));
            dtAppLogger.Columns.Add("Payload", typeof(string));
            dtAppLogger.Columns.Add("HTTPStatusCode", typeof(int));

            int row = 0;

            while (_logQueue.Count > 0)
            {
                if (_logQueue.TryDequeue(out AppLogger? logEntry))
                {
                    if (logEntry == null)
                    {
                        continue;
                    }

                    dtAppLogger.Rows.Add(-1,logEntry.AppLoggerId,
                        logEntry.DateTime,
                        logEntry.LogLevel.ToSafeString().Truncate(16),
                        Environment.ToSafeString().Truncate(16),
                        ApplicationName.ToSafeString().Truncate(128),
                        logEntry.Host.Truncate(1024),
                        logEntry.Path.Truncate(1024),
                        logEntry.Text.ToSafeString().Truncate(2048),
                        logEntry.Exception?.StackTrace ?? String.Empty,
                        logEntry.UserName.Truncate(300),
                        logEntry.QueryJson.Truncate(4096),
                        logEntry.HeadersJson.Truncate(4096),
                        logEntry.UserAgent.Truncate(1024),
                        logEntry.TraceIdentifier.Truncate(64),
                        logEntry.ScopesJson.Truncate(4096),
                        logEntry.Payload ?? String.Empty,
                        logEntry.HTTPStatusCode);

                    row++;

                    //Perform this in chunks, otherwise it may never catch up and persist the errors
                    if (row >= 10000)
                        break;
                }
            }

            if (dtAppLogger.Rows.Count > 0)
            {
                using (SqlBulkCopy sqlBulk = new SqlBulkCopy(_options.ConnectionString))
                {
                    sqlBulk.BulkCopyTimeout = 300;
                    sqlBulk.BatchSize = 1000;
                    sqlBulk.DestinationTableName = _options.LoggerTable;
                    sqlBulk.WriteToServer(dtAppLogger);
                }
            }

            _processingQueue = false;
        }

        void IDisposable.Dispose()
        {
            if (!this.IsDisposed)
            {
                try
                {
                    Dispose(true);
                }
                catch
                {
                }
                
                this.IsDisposed = true;
                GC.SuppressFinalize(this);  // instructs GC not to bother calling the destructor   
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            _terminated = true;
        }

        public bool IsDisposed { get; protected set; }
    }
#endif
}
