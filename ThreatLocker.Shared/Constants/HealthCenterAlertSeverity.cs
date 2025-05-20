using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class HealthCenterAlertSeverity
    {
        public static readonly HealthCenterAlertSeverity Log = new HealthCenterAlertSeverity(0, "log");
        public static readonly HealthCenterAlertSeverity Info = new HealthCenterAlertSeverity(1, "info");
        public static readonly HealthCenterAlertSeverity Warn = new HealthCenterAlertSeverity(5, "warn");
        public static readonly HealthCenterAlertSeverity Error = new HealthCenterAlertSeverity(10, "error");

        public HealthCenterAlertSeverity(int level, string severity)
        {
            ThreatLevel = level;
            Severity = severity;
        }

        public int ThreatLevel { get; set; }
        public string Severity { get; set; }

    }
}
