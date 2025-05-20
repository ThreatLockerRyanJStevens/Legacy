using System;

namespace ThreatLocker.Shared.Models
{
    public class SAMLUserCache
    {
        public Guid SAMLSAMLUserCacheId { get; set; }

        public string UsernameSAML { get; set; }

        public string ResponseAsString { get; set; }

        public DateTime DateCreated { get; set; }

        public int Timeout { get; set; }

        public string RelayState { get; set; }

        public bool TokenProtection { get; set; }

    }
}
