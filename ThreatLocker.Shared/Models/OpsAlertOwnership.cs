using System;

namespace ThreatLocker.Shared.Models
{
    public class OpsAlertOwnership
    {
        public long OpsAlertOwnershipId { get; set; }
        public Guid OpsAlertId { get; set; }
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public Guid ComputerId { get; set; }
        public Guid OrganizationId { get; set; }
        public DateTime DateAssigned { get; set; }
        public int Status { get; set; }
    }
}
