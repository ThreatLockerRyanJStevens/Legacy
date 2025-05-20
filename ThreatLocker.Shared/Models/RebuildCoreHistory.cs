using System;

namespace ThreatLocker.Shared.Models
{
    public class RebuildCoreHistory
    {
        public Guid RebuildCoreHistoryId { get; set; }

        public Guid OrganizationId { get; set; }

        public Guid ComputerId { get; set; }

        public DateTime DateTime { get; set; }

        public string InitiatedBy { get; set; }

    }
}
