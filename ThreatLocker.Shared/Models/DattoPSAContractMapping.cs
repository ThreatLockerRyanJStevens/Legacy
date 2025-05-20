using System;
using System.Collections.Generic;
using System.Linq;
using ThreatLocker.Framework.Extensions;

namespace ThreatLocker.Shared.Models
{
    public class DattoPSAContractMapping
    {
        public long? DattoPSAContractMappingId { get; set; }

        public Guid IntegrationId { get; set; }

        public Guid OrganizationId { get; set; }

        public long ClientId { get; set; }

        public long ContractId { get; set; }

        public long? ServiceId { get; set; }

        public long? ServiceBundleId { get; set; }

        public long? ServiceContractId { get; set; }

        public long? ServiceContractBundleId { get; set; }

        public DateTime LastUpdatedDate { get; set; }

        public string ContractName { get; set; }

        public string ServiceName { get; set; }

        public string ClientName { get; set; }

        public DattoPSAContractMapping() { }

        public DattoPSAContractMapping(DattoPSAContractMapping contractMapping, List<DattoPSAContract> contracts, List<DattoPSAClientMapping> clientMappings) { 
            IntegrationId = contractMapping.IntegrationId;
            ContractId = contractMapping.ContractId;
            OrganizationId = contractMapping.OrganizationId;
            ClientId = contractMapping.ClientId;
            ServiceId = contractMapping.ServiceId;
            ServiceBundleId = contractMapping.ServiceBundleId;
            DattoPSAContractMappingId = contractMapping.DattoPSAContractMappingId;
            ServiceContractId = contractMapping.ServiceContractId;
            ServiceContractBundleId = contractMapping.ServiceContractBundleId;
            PopulateAdditionalMappingInfo(contracts, clientMappings);
        }

        /// <summary>
        /// Gets PSA Client Names and Service/Bundle Names as they are stored in different objects.
        /// </summary>
        /// <param name="contractMapping"></param>
        /// <param name="integrationDto"></param>
        private void PopulateAdditionalMappingInfo(List<DattoPSAContract> contracts, List<DattoPSAClientMapping> dattoClientMappings)
        {
            if (contracts.IsNotNullOrEmpty())
            {
                List<DattoPSAContract> contractsByMap = contracts.Where(w => w.ContractId == ContractId).ToList();

                if (contractsByMap.Any())
                {
                    var contract = contractsByMap.First();
                    ContractName = contract.ContractName;

                    if (contract.Services != null)
                    {
                        var servicesByMap = contract.Services.Where(w => (w.ServiceId == ServiceId && ServiceId > 0)
                            || (w.ServiceBundleId == ServiceBundleId && ServiceBundleId > 0)
                        ).ToList();

                        if (servicesByMap.Any())
                        {
                            ServiceName = servicesByMap.First().Name;
                        }
                    }
                }
            }

            if (dattoClientMappings.IsNotNullOrEmpty())
            {
                List<DattoPSAClientMapping> clientMappings = dattoClientMappings.Where(w => w.ClientId == ClientId).ToList();
                ClientName = clientMappings.First().ClientName;
            }
        }
    }
}
