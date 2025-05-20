using System;

namespace ThreatLocker.Framework.DbLogger
{
#if NET6_0_OR_GREATER

    public class WebApiException
    {
        public WebApiException(Guid loggerId, int statusCode, string message = null, string stackTrace = null)
        {
            LoggerId = loggerId;
            StatusCode = statusCode;
            Message = message;
            StackTrace = stackTrace;
        }

        public Guid LoggerId { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
    }
#endif
}
