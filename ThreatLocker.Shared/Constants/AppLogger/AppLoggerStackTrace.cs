using AngleSharp.Text;

namespace ThreatLocker.Shared.Constants.AppLogger
{
    public class AppLoggerStackTrace
    {
        private static readonly string HtmlIndentedSpace = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;";
        private static readonly string InnerHtmlReplacementString = $"<br>{HtmlIndentedSpace}at ";
        private static readonly string EndOfStackTraceString = "--- End of stack trace from previous location ---";

        public static string FormatStackTrace(string stackTrace)
        {
            stackTrace = stackTrace.Replace(" at ", InnerHtmlReplacementString);
            stackTrace = stackTrace.ReplaceFirst(InnerHtmlReplacementString, " at ");
            stackTrace = stackTrace.Replace(EndOfStackTraceString, $"<br>{HtmlIndentedSpace}{EndOfStackTraceString}");
            return stackTrace;
        }
    }
}
