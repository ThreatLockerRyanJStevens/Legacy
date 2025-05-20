using System;

namespace ThreatLocker.Shared.Models
{
    public class UpdatePolicyMatch
    {
        public long UpdatePolicyMatchId { get; set; }

        public Guid OrganizationId { get; set; }

        public Guid PolicyId { get; set; }

        public bool AllowRemove { get; set; }

        public DateTime? RemoveThreshold { get; set; }

        public DateTime DateTime { get; set; }

        public bool ErrorState { get; set; }

    }
}
