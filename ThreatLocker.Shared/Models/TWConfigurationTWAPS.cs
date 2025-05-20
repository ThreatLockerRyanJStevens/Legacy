using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Models
{
    public class TWConfigurationTWAPS
    {
        public int TWConfigurationTWAPSID { get; set; }

        public Guid? ComputerID { get; set; }

        public string PWord { get; set; }
    }
}
