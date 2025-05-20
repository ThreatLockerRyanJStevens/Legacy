#if NET6_0_OR_GREATER
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
#endif

using System;

namespace ThreatLocker.Framework.DbLogger
{
#if NET6_0_OR_GREATER

    static public class DbLoggerExtensions
    {
        static public ILoggingBuilder AddDbLogger(this ILoggingBuilder builder, Action<DbLoggerOptions> configure)
        {
            builder.Services.AddSingleton<ILoggerProvider, DbLoggerProvider>();
            
            builder.Services.Configure(configure);

            return builder;
        }
    }
#endif
}