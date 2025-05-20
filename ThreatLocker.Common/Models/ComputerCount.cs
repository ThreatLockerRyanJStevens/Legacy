using System;

namespace ThreatLockerCommon.Models
{
    public class ComputerCount
    {
        public Guid OrganizationId { get; set; }
        public int InstalledComputerCount { get; set; }
        public int SecuredComputerCount { get; set; }
    }
}
