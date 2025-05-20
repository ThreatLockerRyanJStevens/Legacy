#if NET6_0_OR_GREATER

using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
#endif

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using ThreatLocker.Framework.Extensions;

namespace ThreatLocker.Framework.DbLogger
{
#if NET6_0_OR_GREATER

    public class DbLogger : ILogger
    {
        private IHttpContextAccessor _httpContextAccessor;

        public DbLogger([NotNull] DbLoggerProvider provider, string category, IHttpContextAccessor httpContextAccessor)
        {
            Provider = provider;
            Category = category;
            _httpContextAccessor = httpContextAccessor;
        }

        public DbLoggerProvider Provider { get; private set; }

        public string Category { get; private set; }

        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return logLevel != LogLevel.None;
        }

        private static string RedactSensitiveInfo(string json)
        {
            var sensitiveKeys = new List<string>() { "password", "passwordlesspin", "sha", "shapassword", "qrsecret", "duointegrationkey", "duosecretKey", "key", "keyword", "apikey", "authkey", "installkey", "splunkkey", "okey", "sha256hash", };

            if (string.IsNullOrEmpty(json))
            {
                return string.Empty;
            }

            JObject obj;

            try
            {
                obj = JObject.Parse(json);
            }
            catch (JsonReaderException)
            {
                return "Request body contains invalid JSON.";
            }

            // Get all properties that match list of keys to redact (all levels)
            IEnumerable<JProperty> properties = Enumerable.Cast<JProperty>(obj.Descendants().Where(w => w is JProperty));
            IEnumerable<JProperty> propertiesToRedact = properties.Where(w => sensitiveKeys.Any(a => a.Equals(w.Name, StringComparison.OrdinalIgnoreCase)));

            foreach (JProperty property in propertiesToRedact)
            {
                property.Value.Replace("***");
            }

            return obj.ToSafeString();
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            if (!IsEnabled(logLevel))
            {
                return;
            }

            try
            {
                AppLogger logEntry = new AppLogger(exception);
                logEntry.Category = this.Category;
                logEntry.LogLevel = logLevel;
                logEntry.Text = exception?.Message ?? state?.ToString() ?? String.Empty; // formatter(state, exception)
                logEntry.State = state;

                if (_httpContextAccessor.HttpContext != null)
                {
                    logEntry.Path = _httpContextAccessor.HttpContext.Request.Path;

                    foreach (var item in _httpContextAccessor.HttpContext.Request.Query)
                    {
                        logEntry.Query.Add(item.Key, item.Value);
                    }

                    string body = exception?.Data["Body"]?.ToString() ?? String.Empty;

                    logEntry.Payload = RedactSensitiveInfo(body);

                    logEntry.Headers = GetHeaders(_httpContextAccessor.HttpContext.Request.Headers);

                    if (_httpContextAccessor.HttpContext.Request.Headers.ContainsKey("Host"))
                    {
                        logEntry.Host = _httpContextAccessor.HttpContext.Request.Headers["Host"];
                    }

                    if (_httpContextAccessor.HttpContext.Request.Headers.ContainsKey("User-Agent"))
                    {
                        logEntry.UserAgent = _httpContextAccessor.HttpContext.Request.Headers["User-Agent"];
                    }

                    logEntry.TraceIdentifier = _httpContextAccessor.HttpContext.TraceIdentifier;

                    if (_httpContextAccessor.HttpContext.Request.Cookies.ContainsKey("ThreatLockerLoggedInUsername"))
                    {
                        logEntry.UserName = _httpContextAccessor.HttpContext.Request.Cookies["ThreatLockerLoggedInUsername"] ?? String.Empty;
                    }
                    else if (_httpContextAccessor.HttpContext.Items.ContainsKey("LoggedInUser"))
                    {
                        logEntry.UserName = _httpContextAccessor.HttpContext.Items["LoggedInUser"].ToSafeString();
                    }

                    logEntry.HTTPStatusCode = _httpContextAccessor.HttpContext.Response.StatusCode;
                }

                // gather info about scope(s), if any
                if (Provider.ScopeProvider != null)
                {
                    Provider.ScopeProvider.ForEachScope((value, loggingProps) =>
                    {
                        if (logEntry.Scopes == null)
                            logEntry.Scopes = new List<DbLogScopeInfo>();

                        DbLogScopeInfo Scope = new DbLogScopeInfo();
                        logEntry.Scopes.Add(Scope);

                        if (value is string)
                        {
                            Scope.Text = value.ToString();
                        }
                        else if (value is IEnumerable<KeyValuePair<string, object>> props)
                        {
                            if (Scope.Properties == null)
                                Scope.Properties = new Dictionary<string, object>();

                            foreach (var pair in props)
                            {
                                Scope.Properties[pair.Key] = pair.Value;
                            }
                        }
                    },
                    state);
                }

                Provider.WriteLog(logEntry);
            }
            catch { }
        }

        private Dictionary<string, string> GetHeaders(IHeaderDictionary requestHeaders)
        {
            var headers = new Dictionary<string, string>();

            try
            {
                string[] filter = new string[] { "Accept", "Host", "User-Agent", ":method", "Accept-Encoding", "Accept-Language", "Cookie", "sec-ch-ua-mobile", "sec-ch-ua", "sec-ch-ua-platform", "sec-fetch-site", "sec-fetch-mode", "sec-fetch-dest" };

                foreach (var item in requestHeaders)
                {
                    if (!filter.Contains(item.Key))
                    {
                        headers.Add(item.Key, item.Value);
                    }
                }
            }
            catch { }
            
            return headers;
        }
    }
#endif
}
