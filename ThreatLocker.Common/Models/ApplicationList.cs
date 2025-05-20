using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class ApplicationList
    {
        public Guid ApplicationId { get; set; }
        public string Name { get; set; }
        public string OrganizationName { get; set; }
        public Guid OrganizationId { get; set; }
        public int OSType { get; set; }
        public Guid? SuggestedPolicyId { get; set; }
    }

    public class OnlineApplicationList
    {
        public Guid ApplicationOnlineId { get; set; }
        public string Name { get; set; }
        public string OrganizationName { get; set; }
        public Guid OrganizationId { get; set; }
        public Guid? SuggestedPolicyId { get; set; }
    }
}
