using System;

namespace ThreatLockerCommon.Models
{
    public class ApplicationListOptions
    {
        public Guid OrganizationId { get; set; }

        public Guid? ParentOrganizationId { get; set; }

        public Guid ComputerId { get; set; }

        public bool IncludeBuiltIn { get; set; }

        public string SearchText { get; set; }
    }
}
