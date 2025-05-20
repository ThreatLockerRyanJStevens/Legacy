using System;

namespace ThreatLockerCommon.Models
{
    public class ResearchApplicationCacheItem
    {
        public ResearchApplicationPackage ResearchApplication { get; set; }
        public DateTime CacheTime { get; set; } = DateTime.UtcNow;
    }
}
