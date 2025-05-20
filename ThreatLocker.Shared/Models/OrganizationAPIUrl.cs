using System;

namespace ThreatLocker.Shared.Models
{
    public class OrganizationAPIUrl
    {
        public Guid OrganizationId { get; set; }

        public int APIUrlId { get; set; }

        public int Cost { get; set; }
    }
}
