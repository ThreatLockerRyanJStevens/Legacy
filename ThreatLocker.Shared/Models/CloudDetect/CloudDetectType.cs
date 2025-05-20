using System;

namespace ThreatLocker.Shared.Models.CloudDetect
{
    public class CloudDetectType
    {
        public int CloudDetectTypeId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public Guid? IntegrationTypeId { get; set; }
        public int? ParentTypeId { get; set; }
        public bool HasChildTypes { get; set; }
    }
}
