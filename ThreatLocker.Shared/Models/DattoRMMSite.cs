using System;

namespace ThreatLocker.Shared.Models
{
    public class DattoRMMSite
    {
        public long DattoRMMSiteId { get; set; }
        public Guid IntegrationId { get; set; }
        public string SiteId { get; set; }
        public string SiteName { get; set; }
        public bool Active { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
