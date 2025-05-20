using System;
using ThreatLockerCommon.Enums;

namespace ThreatLockerCommon.Models
{
    public class AppliesToHierarchy
    {
        public Guid AppliesToId { get; set; }
        public HierarchyLevel HierarchyLevel { get; set; }
    }
}
