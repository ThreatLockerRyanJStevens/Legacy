using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class HealthReport
    {
    }

    [Serializable]
    public class HealthReportRequest
    {
        public string OrganizationId { get; set; }
        public string ConnectionString { get; set; }
        public string OrganizationConnectionString { get; set; }
    }
}
