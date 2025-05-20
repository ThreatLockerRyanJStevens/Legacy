using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class WebsiteUserClient
    {
        public Guid WebsiteUserClientId { get; set; }

        public Guid WebsiteUserId { get; set; }

        public DateTime? SubmitDate { get; set; }

        public string Ip { get; set; }

        public string City { get; set; }

        [JsonProperty("continent_code")]
        public string ContinentCode { get; set; }

        [JsonProperty("continent_name")]
        public string ContinentName { get; set; }

        [JsonProperty("country_capital")]
        public string CountryCapital { get; set; }

        [JsonProperty("country_code2")]
        public string CountryCode2 { get; set; }

        [JsonProperty("country_code3")]
        public string CountryCode3 { get; set; }

        [JsonProperty("country_flag")]
        public string CountryFlag { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("country_tld")]
        public string CountryTld { get; set; }

        public string District { get; set; }

        [JsonProperty("geoname_id")]
        public string GeonameId { get; set; }

        [JsonProperty("is_eu")]
        public bool IsEu { get; set; }

        public string Isp { get; set; }

        public string Languages { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public string Organization { get; set; }

        [JsonProperty("state_prov")]
        public string StateProvidence { get; set; }

        [JsonProperty("zipcode")]
        public string ZipCode { get; set; }

    }
}
