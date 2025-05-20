using System;
using ThreatLocker.Framework.Extensions;

namespace ThreatLocker.Shared.Models
{
    public class DattoPSAClientMapping
    {
        public DattoPSAClientMapping()
        {
            
        }

        public DattoPSAClientMapping(DattoPSACompanyMapping dattoCompanyMapping, Guid integrationId, long dattoPSAClientId)
        {
            OrganizationId = dattoCompanyMapping.OrganizationId.ToSafeGuid();
            ClientName = dattoCompanyMapping.psaCompanyName;
            ClientId = dattoCompanyMapping.PSAId.ToSafeNullableLong();
            IntegrationId = integrationId;
            DattoPSAClientId = dattoPSAClientId;
        }

        public Guid IntegrationId { get; set; }
        public Guid OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public long DattoPSAClientId { get; set; }
        public string ClientName { get; set; }
        public long? ClientId { get; set; }
        public bool Active { get; set; }
        public DateTime CreateDate { get; set; }
        public long? DattoPSAClientMappingId { get; set; }
        public DateTime? LastUpdatedDate { get; set; }

    }
    public class DattoPSACompanyMapping
    {
        public string psaCompanyName { get; set; }
        public int CompanyId { get; set; }
        public string PSAId { get; set; }
        public string RMMId { get; set; }
        public string OrganizationId { get; set; }
    }
}
