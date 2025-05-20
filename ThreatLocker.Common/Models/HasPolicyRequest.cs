using System;

namespace ThreatLockerCommon.Models
{
    public class HasPolicyRequest
    {
        public Guid ApplicationId { get; set; }
        public Guid ComputerId { get; set; }
        public Guid OrganizationId { get; set; }
    }
}