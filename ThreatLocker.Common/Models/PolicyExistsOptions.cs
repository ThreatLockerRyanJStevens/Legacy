using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class PolicyExistsOptions
    {
        public Guid ApplicationId { get; set; }
        public Policy Policy { get; set; }
    }
    public class MacPolicyExistsOptions
    {
        public Guid ApplicationId { get; set; }
        public MacPolicyModel Policy { get; set; }
    }
}
