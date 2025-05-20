using System;

namespace ThreatLocker.Shared.Models
{
    public class NetworkAccessSourceLocation
    {
        public long NetworkAccessSourceLocationId { get; set; }

        public Guid NetworkAccessPolicyId { get; set; }

        public int Type { get; set; }

        public string Value { get; set; }

        public Guid? ObjectId { get; set; }

        public string ObjectName { get; set; }

        public DateTime DateTime { get; set; }

    }
}
