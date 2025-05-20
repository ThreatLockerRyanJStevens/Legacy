using System;
using System.Collections.Generic;
using ThreatLockerCommon.Models;

namespace ThreatLockerCommon.DTOs
{
    [Serializable]
    public class PolicyJsonDto
    {
        public string PolicyId;
        
        public List<PolicySchedule> Schedule = new List<PolicySchedule>();
    }
}
