using System;

namespace ThreatLocker.Shared.Models
{
    public class SAMLUserQueue
    {
        public Guid SAMLUserQueueId { get; set; }

        public string Username { get; set; }

        public string Sha256 { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        public int Timeout { get; set; }

        public bool TokenProtection { get; set; }

    }
}
