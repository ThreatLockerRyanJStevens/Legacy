using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ThreatLockerCommon.Constants;

namespace ThreatLockerCommon.Models
{
    [Serializable]
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

    [Serializable]
    public class NetworkAccessPolicyDTO
    {
        public Guid NetworkAccessPolicyId { get; set; }
        public string Name { get; set; }
        public int PolicyActionId { get; set; } //1 = permit, 2 = deny
        public List<NetworkAccessRuleDTO> Rules { get; set; } = new List<NetworkAccessRuleDTO>();
        public int Protocol { get; set; } = 1;
        public int Status { get; set; }
        public int Direction { get; set; } = NetworkPolicyDirection.Inbound.Id;
        public DateTime? EndDate { get; set; }
        public List<PolicySchedule> Schedule { get; set; } = new List<PolicySchedule>();
        [JsonIgnore]
        public int OrderBy { get; set; }
    }
}
