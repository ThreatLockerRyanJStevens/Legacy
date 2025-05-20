using System;

namespace ThreatLocker.Shared.Models.CloudDetect
{
    public class CloudDetectPolicyAction
    {
        public long CloudDetectPolicyActionId { get; set; }
        public Guid CloudDetectPolicyId { get; set; }
        public int CloudDetectActionId { get; set; }
    }
}
