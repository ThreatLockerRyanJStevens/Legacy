using System;

namespace ThreatLocker.Shared.Models
{
    public class TouchPointType
    {
        public Guid TouchPointTypeId { get; set; }

        public string TypeName { get; set; }

        public bool IsActive { get; set; }

        public bool IsSalesEngineer { get; set; }

        public bool IsSalesPerson { get; set; }
    }
}
