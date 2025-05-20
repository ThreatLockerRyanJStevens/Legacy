using System;

namespace ThreatLocker.Shared.Models
{
    public class TWConfiguration
    {
        public int TWConfigurationID { get; set; }

        public string Name { get; set; }

        public int TWConfigurationTypeID { get; set; }

        public int TWConfigurationCategoryID { get; set; }

        public string DisplayIcon { get; set; }

        public bool? IsEnabled { get; set; }

        public DateTime? DateAdded { get; set; }

        public string EnabledPreSaveMessage { get; set; }

        public string DisabledPreSaveMessage { get; set; }

    }
}
