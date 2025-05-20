using System;

namespace ThreatLocker.Shared.Models
{
    public class LogonRestrinction
    {
        public Guid LogonRestrinctionId { get; set; }

        public Guid ObjectId { get; set; }

        public string AllowedCountryCodes { get; set; }

        public string BlockedCountryCodes { get; set; }

        public string AllowedRegions { get; set; }

        public string BlockedRegions { get; set; }

        public string AllowedIPAddresses { get; set; }

        public string BlockedIPAddresses { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public int Priority { get; set; }

        public bool IsActive { get; set; }

        public bool RestrictCountry { get; set; }

        public bool RestrictIP { get; set; }

        public bool RestrictUsers { get; set; }

    }
}
