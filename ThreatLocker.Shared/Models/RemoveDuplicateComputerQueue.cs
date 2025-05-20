using System;

namespace ThreatLocker.Shared.Models
{
    public class RemoveDuplicateComputerQueue
    {
        public long RemoveDuplicateComputerQueueId { get; set; }

        public DateTime DateTime { get; set; }

        public Guid OrganizationId { get; set; }

        public string RequestedBy { get; set; }

    }
}
