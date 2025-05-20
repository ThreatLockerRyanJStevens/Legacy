using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class VirusTotalCategoryType
    {
        public static readonly VirusTotalCategoryType ConfirmedTimeout = new VirusTotalCategoryType("confirmed-timeout", "Confirmed Timeout");
        public static readonly VirusTotalCategoryType Failure = new VirusTotalCategoryType("failure", "Failure");
        public static readonly VirusTotalCategoryType Harmless = new VirusTotalCategoryType("harmless", "Harmless");
        public static readonly VirusTotalCategoryType Undetected = new VirusTotalCategoryType("undetected", "Undetected");
        public static readonly VirusTotalCategoryType Suspicious = new VirusTotalCategoryType("suspicious", "Suspicious");
        public static readonly VirusTotalCategoryType Malicious = new VirusTotalCategoryType("malicious", "Malicious");
        public static readonly VirusTotalCategoryType TypeUnsupported = new VirusTotalCategoryType("type-unsupported", "Type Unsupported");
        public static readonly VirusTotalCategoryType SeverityNone = new VirusTotalCategoryType("SEVERITY_NONE", "Severity None");

        public VirusTotalCategoryType(string value, string name)
        {
            Value = value;
            Name = name;
        }

        public string Value { get; set; }
        public string Name { get; set; }

        public static readonly VirusTotalCategoryType[] All =
        {
            ConfirmedTimeout,
            Failure,
            Harmless,
            Undetected,
            Suspicious,
            Malicious,
            TypeUnsupported,
            SeverityNone
        };

        public static readonly string[] MaliciousStates =
        {
            Suspicious.Value,
            Malicious.Value
        };

        public static readonly string[] InconclusiveStates =
        {
            ConfirmedTimeout.Value,
            Failure.Value,
            TypeUnsupported.Value
        };

        public static readonly string[] BenignStates =
        {
            Harmless.Value,
            Undetected.Value
        };

        public static VirusTotalCategoryType Find(string value)
        {
            return All.FirstOrDefault(x => x.Value == value);
        }

        public static VirusTotalCategoryType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
