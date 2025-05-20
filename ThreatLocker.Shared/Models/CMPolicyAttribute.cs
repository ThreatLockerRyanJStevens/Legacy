using System;

namespace ThreatLocker.Shared.Models
{
    public class CMPolicyAttribute
    {
        public int CMPolicyAttributeId { get; set; }

        public int CMConfigurationAttributeId { get; set; }

        public Guid CMPolicyId { get; set; }

        public string Value { get; set; }
    }

}