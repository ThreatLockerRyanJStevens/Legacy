using System;

namespace ThreatLocker.Shared.Models
{
    public class GroupVerifierQueue
    {
        public long GroupVerifierQueueId { get; set; }
        public Guid OrganizationId { get; set; }
        public Guid GroupId { get; set; }
        public string GroupName { get; set; }
        public int OSType { get; set; }
        public bool IsDefault { get; set; }
        public string RequestedBy { get; set; }
        public DateTime RequestedDateTime { get; set; }
    }
}
