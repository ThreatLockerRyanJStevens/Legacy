using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class AlertSeverityType
    {
        public static readonly AlertSeverityType All = new AlertSeverityType(0, "All");
        public static readonly AlertSeverityType Log = new AlertSeverityType(1, "Log");
        public static readonly AlertSeverityType Information = new AlertSeverityType(2, "Information");
        public static readonly AlertSeverityType Warning = new AlertSeverityType(3, "Warning");
        public static readonly AlertSeverityType Severe = new AlertSeverityType(4, "Severe");

        public AlertSeverityType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly AlertSeverityType[] AllTypes =
        {
            Log,
            Information,
            Warning, 
            Severe
        };

        public static readonly int[] AlertCenterTypes =
        {
            Warning.Id,
            Severe.Id
        };

        public static AlertSeverityType Find(int id)
        {
            return AllTypes.FirstOrDefault(x => x.Id == id);
        }

        public static AlertSeverityType FindByName(string name)
        {
            return AllTypes.FirstOrDefault(x => x.Name.ToLower() == name);
        }
    }
}
