using System;

namespace ThreatLocker.Shared.Constants
{
    public class APISourceType
    {
        public static string Portal => "Portal";
        public static string iOS => "iOS";
        public static string Android => "Android";
        public static string ApplicationService => "ApplicationService";

        public static bool IsMobile(string sourceType)
        {
            return sourceType.Equals(iOS, StringComparison.OrdinalIgnoreCase)
                || sourceType.Equals(Android, StringComparison.OrdinalIgnoreCase);
        }
    }
}
