using System;

namespace ThreatLocker.Shared.Models
{
    public class CMConfiguration
    {
        public int CMConfigurationID { get; set; }

        public int CMConfigurationCategoryID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool? IsEnabled { get; set; }

        public DateTime? DateCreated { get; set; }

        public int CMConfigAgentId { get; set; }
    }
}
