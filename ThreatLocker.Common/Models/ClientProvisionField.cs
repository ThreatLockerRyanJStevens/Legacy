using System;

namespace ThreatLockerCommon.Models
{
    public class ClientProvisionField
    {
        public string TimeZone { get; set; }
        public string CompanyName { get; set; }
        public string GroupName { get; set; }
        public string Email { get; set; }
        public Guid OrganizationId { get; set; }
    }
}
