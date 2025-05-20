using System.Collections.Generic;

namespace ThreatLockerCommon.Models
{
    public class ClientProvision
    {
        public Organization Organization { get; set; }

        public List<Contact> Contact { get; set; }
    }
}
