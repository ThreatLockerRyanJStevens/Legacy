using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class OpsAlertSeverityType
    {
        public static readonly OpsAlertSeverityType Information = new OpsAlertSeverityType(2, "info");
        public static readonly OpsAlertSeverityType Warning = new OpsAlertSeverityType(3, "warn");
        public static readonly OpsAlertSeverityType Severe = new OpsAlertSeverityType(4, "error");

        public OpsAlertSeverityType(int id, string code)
        {
            Id = id;
            Code = code;
        }

        public int Id { get; set; }
        public string Code { get; set; }
        
        public static readonly OpsAlertSeverityType[] All =
        {
            Information,
            Warning,
            Severe
        };

        //Optional Find method
        public static OpsAlertSeverityType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static OpsAlertSeverityType FindByCode(string code)
        {
            return All.FirstOrDefault(x => x.Code.Equals(code, System.StringComparison.OrdinalIgnoreCase));
        }
    }
}
