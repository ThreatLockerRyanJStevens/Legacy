using System;

namespace ThreatLocker.Shared.Models
{
    public class HaloPSAClientMapping
    {
        public Guid IntegrationId { get; set; }

        public Guid OrganizationId { get; set; }

        public string OrganizationName { get; set; }

        // Internal PK on Threatlocker database table HaloPSAClient
        public long HaloPSAClientId { get; set; }

        public string ClientName { get; set; }

        // external Client Id from HaloPSA API
        public long? ClientId { get; set; }

        public bool Active { get; set; }

        public DateTime CreateDate { get; set; }

        public long? HaloPSAClientMappingId { get; set; }

        public DateTime? LastUpdatedDate { get; set; }

    }
}
