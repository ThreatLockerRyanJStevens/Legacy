using System;

namespace ThreatLocker.Shared.Models
{
    public class DattoPSAService
    {
        public long DattoPSAServiceId { get; set; }

        public Guid IntegrationId { get; set; }

        public long ContractId { get; set; }

        public long ServiceContractId { get; set; }

        public long? ServiceId { get; set; }

        public long? ServiceBundleId { get; set; }

        public string Name { get; set; }

        public bool Active { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? LastUpdatedDate { get; set; }

        public DattoPSAService() { }

        public DattoPSAService(DattoPSAAPIService service, DattoPSAContractService contractService, Guid integrationId, bool isBundle)
        {
            Active = true;
            if (isBundle)
            {
                ServiceBundleId = service.Id;
            }
            else
            {
                ServiceId = service.Id;
            }

            Name = service.Name;
            IntegrationId = integrationId;
            ServiceContractId = contractService.Id;
            ContractId = contractService.ContractId;
        }

        public DattoPSAService(DattoPSAService service, string serviceName) {
            Active = service.Active;
            ServiceBundleId = service.ServiceBundleId;
            ServiceId = service.ServiceId;
            Name = serviceName;
            IntegrationId = service.IntegrationId;
            ServiceContractId = service.ServiceContractId;
            ContractId = service.ContractId;
        }

    }
}
