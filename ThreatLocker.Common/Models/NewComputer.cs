using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class NewComputer
    {
        public Guid ComputerId { get; set; }
        public string AuthKey { get; set; }
        public string PrivateKey { get; set; }
    }
}
