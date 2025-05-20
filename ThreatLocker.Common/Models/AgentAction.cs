using System;
using ThreatLockerCommon.DTOs;

namespace ThreatLockerCommon.Models
{
    public class AgentAction : AgentActionDto
    {
        public Guid AppliesToId { get; set; }
        public Guid OrganizationId { get; set; }
        public string CreatedBy { get; set; }
    }
}
