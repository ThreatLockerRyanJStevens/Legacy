using System;
using System.Collections.Generic;

namespace ThreatLocker.Shared.Models
{
    public class ComputerCheckin
    {
        public long ComputerCheckinId { get; set; }

        public Guid OrganizationId { get; set; }

        public Guid ComputerId { get; set; }

        public DateTime DateTime { get; set; }

        public long MemoryUsage { get; set; }

        public string MemoryUsageUnit { get; set; }

        public string IPAddress { get; set; }

        public int DriverStatus { get; set; }

        public string TLVersion { get; set; }

        public int? CoreCount { get; set; }

        public string OperatingSystem { get; set; }

        public List<string> LocalIPAddresses { get; set; } = new List<string>();
    }
}
