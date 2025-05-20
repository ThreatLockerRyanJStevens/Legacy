using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.DTOs
{
    public class PolicyCreateTemp
    {
        public Guid PolicyId { get; set; }
        public Guid? TempPolicyId { get; set; }
        public Guid ApplicationId { get; set; }
        public Guid? ComputerGroupId { get; set; }
        public DateTime EndDate { get; set; }
    }
}
