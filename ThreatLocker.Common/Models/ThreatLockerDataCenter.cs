using System;

namespace ThreatLockerCommon.Models
{
    [Serializable]
    public class ThreatLockerDataCenter
    {
        public Guid ThreatLockerDataCenterId { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string ApiUrl { get; set; }
        public bool IsActive { get; set; }
        public string PortalUrl { get; set; }
        public string AuthKey { get; set; }
        public string InstanceName { get; set; }
        public string CRMApiUrl { get; set; }
    }
}
