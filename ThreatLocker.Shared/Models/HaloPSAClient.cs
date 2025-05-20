using System;

namespace ThreatLocker.Shared.Models
{
    public class HaloPSAClient
    {
        public long HaloPSAClientId { get; set; }

        public Guid IntegrationId { get; set; }

        public long ClientId { get; set; }

        public string ClientName { get; set; }

        public bool Active { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime LastUpdatedDate { get; set; }

    }
}
