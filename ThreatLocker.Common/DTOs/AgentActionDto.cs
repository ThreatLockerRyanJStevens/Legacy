using System;
using System.Collections.Generic;
using ThreatLockerCommon.Enums;

namespace ThreatLockerCommon.DTOs
{
    public class AgentActionDto
    {
        public long AgentActionId { get; set; }
        public AgentActionType Type { get; set; }
        public object Payload { get; set; }
    }

    public class AgentActionComparer : IEqualityComparer<AgentActionDto>
    {
        public bool Equals(AgentActionDto x, AgentActionDto y)
        {
            return x.Type == y.Type &&
                x.Payload == y.Payload;
        }

        public int GetHashCode(AgentActionDto obj)
        {
            return obj.Type.GetHashCode() ^
                obj.Payload.GetHashCode();
        }
    }
}
