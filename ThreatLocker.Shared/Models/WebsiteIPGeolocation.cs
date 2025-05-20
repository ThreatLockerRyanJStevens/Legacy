using Newtonsoft.Json;
using System;

namespace ThreatLocker.Shared.Models
{
    public class WebsiteIPGeolocation
    {
        public Guid WebsiteIpGeolocationId { get; set; }

        public Guid WebsiteUserId { get; set; }

        public DateTime SubmitDate { get; set; }

        public string IP { get; set; }

        public bool Success { get; set; }

        public string Type { get; set; }

        public string Continent { get; set; }

        [JsonProperty("continent_code")]
        public string ContinentCode { get; set; }

        public string Country { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        public string Region { get; set; }

        [JsonProperty("region_code")]
        public string RegionCode { get; set; }

        public string City { get; set; }

        public decimal? Latitude { get; set; }

        public decimal? Longitude { get; set; }

        [JsonProperty("is_eu")]
        public bool IsEU { get; set; }
        public string Postal { get; set; }
        [JsonProperty("calling_code")]
        public string CallingCode { get; set; }
        public string Capital { get; set; }
        public string Borders { get; set; }

        public Flag Flag { get; set; }
        public Connection Connection { get; set; }
        public Timezone Timezone { get; set; }
        public Currency Currency { get; set; }

        // TODO remove this.
        [JsonProperty("completed_requests")]
        public long? CompletedRequests { get; set; }

    }

    public class Connection
    {
        public int Asn { get; set; }
        public string Org { get; set; }
        public string Isp { get; set; }
        public string Domain { get; set; }
    }

    public class Currency
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Symbol { get; set; }
        public string Plural { get; set; }
        [JsonProperty("exchange_rate")]
        public decimal ExchangeRate { get; set; }
    }

    public class Flag
    {
        public string Img { get; set; }
        public string Emoji { get; set; }
        [JsonProperty("emoji_unicode")]
        public string EmojiUnicode { get; set; }
    }

    public class Timezone
    {
        public string Id { get; set; }
        public string Abbr { get; set; }
        [JsonProperty("is_dst")]
        public bool IsDst { get; set; }
        public int Offset { get; set; }
        public string Utc { get; set; }
        [JsonProperty("current_time")]
        public DateTime CurrentTime { get; set; }
    }
}
