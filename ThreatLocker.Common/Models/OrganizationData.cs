using System;

namespace ThreatLockerCommon.Models
{
    public class OrganizationData
    {
        public Guid OrganizationId { get; set; }
        public int? InstalledComputers { get; set; }
        public int? SecuredComputers { get; set; }
    }
}
