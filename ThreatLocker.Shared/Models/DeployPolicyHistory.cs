using System;

namespace ThreatLocker.Shared.Models
{
    public class DeployPolicyHistory
    {
        public int DeployPolicyHistoryId { get; set; }

        public Guid? OrganizationId { get; set; }

        public DateTime? DateTime { get; set; }

        public string Source { get; set; }

    }
}
