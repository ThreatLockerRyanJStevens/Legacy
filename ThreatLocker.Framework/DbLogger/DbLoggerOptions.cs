#if NET6_0_OR_GREATER
using Microsoft.Extensions.Logging;
#endif

namespace ThreatLocker.Framework.DbLogger
{
#if NET6_0_OR_GREATER

    public class DbLoggerOptions
    {
        public string ConnectionString { get; init; }
        public string LoggerTable { get; init; }
        public LogLevel LogLevel { get; set; } = LogLevel.None;
    }
#endif

}
