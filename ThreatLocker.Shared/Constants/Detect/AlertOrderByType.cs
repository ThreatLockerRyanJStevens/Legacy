using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class AlertOrderByType
    {
        public static readonly AlertOrderByType DateCreated = new AlertOrderByType("date-created", "Date Created");
        public static readonly AlertOrderByType DateModified = new AlertOrderByType("date-modified", "Date Modified");
        public static readonly AlertOrderByType Organization = new AlertOrderByType("organization", "Organization");
        public static readonly AlertOrderByType MostRecentAlert = new AlertOrderByType("recent-alert", "Most Recent Alert");
        public static readonly AlertOrderByType ActiveAlerts = new AlertOrderByType("active-alerts", "Active Alerts");
        public static readonly AlertOrderByType ThreatLevel = new AlertOrderByType("threat-level", "Threat Level");

        public AlertOrderByType(string value, string name)
        {
            Value = value;
            Name = name;
        }

        public string Value { get; set; }
        public string Name { get; set; }

        public static readonly AlertOrderByType[] All =
        {
            DateCreated,
            DateModified,
            Organization, 
            MostRecentAlert,
            ActiveAlerts,
            ThreatLevel
        };

        public static AlertOrderByType Find(string value)
        {
            return All.FirstOrDefault(x => x.Value == value);
        }

        public static AlertOrderByType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name.ToLower() == name);
        }
    }
}
