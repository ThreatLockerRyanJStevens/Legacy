using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class OrganizationDomain
    {
        public Guid OrganizationId { get; set; }
        public string Domain { get; set; }
    }
}
