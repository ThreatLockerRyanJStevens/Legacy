using System;

namespace ThreatLocker.Shared.Models
{
    public class Exclusion
    {
        public long ExclusionId { get; set; }

        public Guid ObjectId { get; set; }

        public int ObjectTypeId { get; set; }

        public int ExclusionType { get; set; }

        public string Value { get; set; }

        public int OSType { get; set; }

    }

}
