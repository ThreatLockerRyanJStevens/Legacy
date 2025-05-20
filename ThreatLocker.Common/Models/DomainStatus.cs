using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class DomainStatus
    {
        public string Domain { get; set; }

        public int Status { get; set; }

        public enum DomainStatuses
        {
            NotRegistered = 0,
            RegisteredToCurrentPartner = 1,
            RegisteredToThreatLockerLead = 2,
            RegisteredToAnotherPartner = 3
        };
    }
}
