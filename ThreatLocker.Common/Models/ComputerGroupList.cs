using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class ComputerGroupList
    {
        public Guid ComputerGroupId { get; set; }
        public string Name { get; set; }
        public string OrganizationName { get; set; }
        public Guid OrganizationId { get; set; }
    }
}
