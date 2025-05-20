using System;
using System.Collections.Generic;

namespace ThreatLockerCommon.Models
{
    // {CP} {DV-9978} Used by CloudDetectPolicyMatchProcessing and Office365LogShipper
    public class CloudDetectType
    {
        public int CloudDetectTypeId { get; set; }
        public string Name { get; set; }
        public string ObjectType { get; set; }
        public string ObjectNameType { get; set; }
        public Guid IntegrationTypeId { get; set; }
    }
}
