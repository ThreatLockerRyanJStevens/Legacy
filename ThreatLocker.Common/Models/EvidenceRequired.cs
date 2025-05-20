using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    [Serializable]
    public class EvidenceRequired
    {
        public string Description { get; set; }
        public int ActionTaken { get; set; }//1 = noupdate,2=captured,3=both
    }
}
