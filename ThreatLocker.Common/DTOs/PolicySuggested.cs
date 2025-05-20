using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.DTOs
{
    public class PolicySuggested
    {
        public Guid ApplicationId { get; set; }
        public Guid ComputerGroupId { get; set; }
        public Guid OrganizationId { get; set; }
        public bool IsEnabled { get; set; }
    }
}
