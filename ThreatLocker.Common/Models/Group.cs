using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class Group
    {
        public string GroupName { get; set; }
        public string DistinguishedName { get; set; }
        public List<GroupMember> Members { get; set; }
    }
    public class GroupMember
    {
        public string SAMAccountName { get; set; }
    }
    public class ActiveDirectory
    {

        public string ComputerId { get; set; }
        public List<Group> Groups { get; set; }
    }
}
