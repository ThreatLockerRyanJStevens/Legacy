#if NET6_0_OR_GREATER
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
#endif
using System;
using System.Collections.Generic;

namespace ThreatLocker.Framework.DbLogger
{
#if NET6_0_OR_GREATER

    public class AppLogger
    {
        public AppLogger(Exception exception)
        {
            if (exception != null)
            {
                if (exception.Data.Contains("AppLoggerId"))
                {
                    AppLoggerId = (exception.Data["AppLoggerId"] as Guid?) ?? Guid.NewGuid();
                }
                else
                {
                    AppLoggerId = Guid.NewGuid();
                }

                if (exception.Data.Contains("Payload"))
                {
                    Payload = (exception.Data["Payload"] as string) ?? string.Empty;
                }

                Exception = exception;
            }
            else
            {
                AppLoggerId = Guid.NewGuid();
            }
            
            DateTime = DateTime.UtcNow;
        }


        public Guid AppLoggerId { get; init; }
        public string UserName { get; set; } = String.Empty;
        public string Host { get; set; } = String.Empty;
        public DateTime DateTime { get; init; }
        public string Category { get; set; } = String.Empty;
        public LogLevel LogLevel { get; set; }
        public string Text { get; set; } = String.Empty;
        public Exception Exception { get; init; }
        public Dictionary<string, string> Query { get; set; } = new Dictionary<string, string>();
        public string QueryJson => JsonConvert.SerializeObject(Query);
        public Dictionary<string, string> Headers { get; set; } = new Dictionary<string, string>();
        public string HeadersJson => JsonConvert.SerializeObject(Headers);
        public string Path { get; set; } = String.Empty;
        public string UserAgent { get; set; } = String.Empty;
        public object State { get; set; }
        public List<DbLogScopeInfo> Scopes { get; set; } = new List<DbLogScopeInfo>();
        public string ScopesJson => JsonConvert.SerializeObject(Scopes);
        public string Environment { get; set; } = String.Empty;
        public string TraceIdentifier { get; set; } = String.Empty;
        public string? Payload { get; set; }
        public int HTTPStatusCode { get; set; }
    }
#endif
}
