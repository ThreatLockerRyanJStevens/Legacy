using System;
using System.Collections.Generic;

namespace ThreatLocker.Shared.Models
{
    public class NetworkAccessPolicy
    {
        public Guid NetworkAccessPolicyId { get; set; }
        public Guid AppliesToId { get; set; }
        public int AppliesToType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public int PolicyActionId { get; set; } //1 = permit, 2 = deny
        public bool IsEnabled { get; set; }
        public List<NetworkAccessRule> Rules { get; set; } = new List<NetworkAccessRule>();
        public DateTime CreatedDate { get; set; }
        public Guid OrganizationId { get; set; }
        public string PolicyActionIcon { get; set; }
        public string IsEnabledChecked { get; set; }
        public int OrderBy { get; set; }
    }
}
