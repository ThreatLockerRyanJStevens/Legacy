using System;
using System.Collections.Generic;

namespace ThreatLockerCommon.Models
{
    public class RiskApplication
    {
        public List<Guid> MatchingApplicationIds { get; set; }
        public ResearchApplicationPackage ResearchApplication { get; set; }
        public List<int> RiskTypeIds { get; set; }
    }
}
