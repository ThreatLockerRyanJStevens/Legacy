using System;

namespace ThreatLocker.Shared.Models.CloudDetect
{
    public class CloudDetectAlertOwnership
    {
        public long CloudDetectAlertOwnershipId { get; set; }
        public Guid OrganizationId { get; set; }
        public string ObjectId { get; set; }
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public DateTime DateAssigned { get; set; }
        public int Status { get; set; }
    }
}
