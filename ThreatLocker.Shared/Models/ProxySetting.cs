using System;

namespace ThreatLocker.Shared.Models
{
    public class ProxySetting
    {
        public Guid ProxySettingId { get; set; }

        public Guid? EntityId { get; set; }

        public int? EntityType { get; set; }

        public string URL { get; set; }

        public bool BypassOnLocal { get; set; }

        public string BypassList { get; set; }

        public DateTime CreatedOn { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public string UpdatedBy { get; set; }

    }
}
