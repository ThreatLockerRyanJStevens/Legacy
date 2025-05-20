using System;

namespace ThreatLockerCommon.Models
{
    public class PolicyDeployOptions
    {
        public Guid ComputerId { get; set; }

        public string SourceNote { get; set; }

        public string AdditionalQueue { get; set; }

        public Guid GroupOrOrgId { get; set; }

        public Guid OrganizationId { get; set; }
    }
}
