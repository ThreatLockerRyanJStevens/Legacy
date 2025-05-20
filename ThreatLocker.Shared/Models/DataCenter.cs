using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Models
{
    public class DataCenter
    {
        public Guid DataCenterId { get; set; }

        public string Name { get; set; }

        public string InstanceName { get; set; }

        public string AuthKey { get; set; }

        public bool IsActive { get; set; }
    }
}
