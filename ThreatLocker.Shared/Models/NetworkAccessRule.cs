using System;
using System.Collections.Generic;

namespace ThreatLocker.Shared.Models
{
    public class NetworkAccessRule
    {
        public Guid NetworkAccessRuleId { get; set; }
        public Guid NetworkAccessPolicyId { get; set; }
        public int Type { get; set; } //1 = source, 2 = destination NOTE: (destination = server) (source = client)
        public List<NetworkAccessRuleLocation> Locations { get; set; } = new List<NetworkAccessRuleLocation>();
        public List<PortRange> PortRanges { get; set; } = new List<PortRange>();
    }

    public class PortRange
    {
        public int MinPort { get; set; }
        public int MaxPort { get; set; }
    }

    public class NetworkAccessRuleLocation
    {
        public int Type { get; set; }   //Use NetworkAccessRuleLocationType
        public string Value { get; set; }
        public Guid? TagId { get; set; }
        public string TagName { get; set; }
    }
}
