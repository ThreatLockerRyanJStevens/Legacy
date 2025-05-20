using Newtonsoft.Json;
using System;

namespace ThreatLockerCommon.Models
{
    public class GeoLocationData
    {
        public string IPAddress { get; set; } = string.Empty;
        public string CountryCode { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
    }

    public class IPWhoIsData
    {
        public bool success { get; set; }
        [JsonProperty("country_code")]
        public string countrycode { get; set; }
        public string region { get; set; }
        public string city { get; set; }
        public string isp { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
    }

    public class LogonRestrictions
    {
        public bool Active = false;
        public string AllowedIPAddresses { get; set; }
        public string BlockedIPAddresses { get; set; }
        public string AllowedRegions { get; set; }
        public string BlockedRegions { get; set; }
        public string AllowedCountryCodes { get; set; }
        public string BlockedCountryCodes { get; set; }
    }
}
