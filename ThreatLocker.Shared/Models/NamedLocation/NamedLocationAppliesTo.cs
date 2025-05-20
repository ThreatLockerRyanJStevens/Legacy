using System;
using System.Collections.Generic;
using ThreatLocker.Shared.Constants;

namespace ThreatLocker.Shared.Models.NamedLocation
{
    public class NamedLocationAppliesTo
    {
        public Guid AppliesToId { get; set; }
        public int AppliesToType { get; set; }
    }

    public class NamedLocationAppliesToGroup
    {
        public int AppliesToGroupType { get; set; }
        public List<Guid> AppliesToIds { get; set; }
    }
}
