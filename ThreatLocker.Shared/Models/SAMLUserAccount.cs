using System;

namespace ThreatLocker.Shared.Models
{
    public class SAMLUserAccount
    {
        public Guid SAMLUserAccountId { get; set; }

        public Guid UserId { get; set; }

        public string Username { get; set; }

        public string UsernameSAML { get; set; }

        public Guid OrganizationId { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }

        public bool Active { get; set; }

        public bool Validated { get; set; }

    }

}
