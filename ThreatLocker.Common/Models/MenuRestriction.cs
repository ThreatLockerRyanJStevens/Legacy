using System;

namespace ThreatLockerCommon.Models
{
    public class MenuRestriction
    {
        public Guid MenuRestrictionId { get; set; }
        public Guid MenuId { get; set; }
        public Guid OrganizationId { get; set; }
    }
}