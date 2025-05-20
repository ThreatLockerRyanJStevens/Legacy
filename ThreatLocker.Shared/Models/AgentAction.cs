using System;

namespace ThreatLocker.Shared.Models
{
    public class AgentAction
    {
        public Guid AgentActionId { get; set; }
        public int AgentActionTypeId {  get; set; }
        public Guid AppliesToId { get; set; }
        public string Payload { get; set; }
        public Guid OrganizationId { get; set; }
        public string CreatedBy { get; set; }
    }
}
