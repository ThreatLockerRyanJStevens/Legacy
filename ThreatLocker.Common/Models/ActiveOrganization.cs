using System.Collections.Generic;

namespace ThreatLockerCommon.Models
{
    public class ActiveOrganization
    {
        public ActiveOrganization()
        {
            ChildOrganizationIds = new List<string>();
        }

        public string AuthenticatedOrganizationId { get; set; }
        public string ManagedOrganizationId { get; set; }
        public List<string> ChildOrganizationIds { get; private set; }
    }
}
