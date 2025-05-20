using System.Collections.Generic;
using System.Linq;

namespace ThreatLocker.Shared.Models
{
    public class DattoPSAContractService : DattoPSAAPIService
    {
        public long ContractId { get; set; }
        public long ServiceId { get; set; }
        public long ServiceBundleID { get; set; }

        public long ServiceUnifiedId { 
            get
            {
                if (ServiceBundleID > 0)
                {
                    return ServiceBundleID;
                }
                else
                {
                    return ServiceId;
                }
            } 
        }

        public DattoPSAContractService() { }

        public DattoPSAContractService(DattoPSAContractService contract, List<DattoPSAAPIService> dattoPSAAPIServices)
        {
            ContractId = contract.ContractId;
            ServiceId = contract.ServiceId;
            ServiceBundleID = contract.ServiceBundleID;
            Id = contract.Id;

            List<DattoPSAAPIService> services;

            if (contract.ServiceBundleID > 0)
            {
                services = dattoPSAAPIServices.Where(w => w.Id == contract.ServiceBundleID).ToList();
            }
            else
            {
                services = dattoPSAAPIServices.Where(w => w.Id == contract.ServiceId).ToList();
            }
            
            if(services.Any())
            {
                Name = services.First().Name;
            }
            
        }
    }
}
