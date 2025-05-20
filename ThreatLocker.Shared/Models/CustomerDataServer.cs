using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Models
{
    public class CustomerDataServer
    {
        public string ServerName { get; set; }
        public string RemoteAPIURL { get; set; }
        public int Site { get; set; }
        public bool IsActive { get; set; }
    }
}
