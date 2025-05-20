using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Models
{
    public class DataCenterEnvironment
    {
        public Guid DataCenterEnvironmentId { get; set; }

        public Guid DataCenterId { get; set; }

        public string Environment { get; set; }

        public string PortalUrl { get; set; }

        public string PortalApiUrl { get; set; }
    }
}
