using System;

namespace ThreatLocker.Shared.Models
{
    public class OrganizationBillingContact
    {
        public Guid OrganizationBillingContactId { get; set; }

        public string SignerName { get; set; }

        public string SignerEmail { get; set; }

        public Guid OrganizationId { get; set; }

        public bool Active { get; set; }

    }
}
