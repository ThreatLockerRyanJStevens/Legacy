using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ThreatLocker.Shared.Models
{
    public class DattoPSAContract
    {
        public DattoPSAContract() { }

        public DattoPSAContract(DattoPSAContract contract, Guid integrationId)
        {
            ClientId = contract.ClientId;
            Active = true;
            ContractId = contract.ContractId;
            ContractName = contract.ContractName;
            IntegrationId = integrationId;
        }

        public DattoPSAContract(DattoPSAContract contract, Guid integrationId, List<DattoPSAService> services)
        {
            ClientId = contract.ClientId;
            Active = contract.Active;
            ContractId = contract.ContractId;
            ContractName = contract.ContractName;
            IntegrationId = integrationId;
            Services = services.Where(w => w.ContractId == ContractId).ToList();
        }

        public DattoPSAContract(DattoPSAContract contract, string contractName)
        {
            ClientId = contract.ClientId;
            Active = contract.Active;
            ContractId = contract.ContractId;
            ContractName = contractName;
            IntegrationId = contract.IntegrationId;
            DattoPSAContractId = contract.DattoPSAContractId;
        }

        [JsonProperty("id")]
        public long ContractId { get; set; }

        [JsonProperty("companyId")]
        public long ClientId { get; set; }

        [JsonProperty("contractName")]
        public string ContractName { get; set; }

        public long DattoPSAContractId { get; set; }

        public Guid IntegrationId { get; set; }

        public bool Active { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? LastUpdatedDate { get; set; }

        public List<DattoPSAService> Services { get; set; }
    }
}
