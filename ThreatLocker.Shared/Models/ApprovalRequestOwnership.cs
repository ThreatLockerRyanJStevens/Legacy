using System;

namespace ThreatLocker.Shared.Models
{
    public class ApprovalRequestOwnership
    {
        public long ApprovalRequestOwnershipId { get; set; }

        public Guid ApprovalRequestId { get; set; }

        public Guid UserId { get; set; }

    }
}
