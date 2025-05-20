using System.Collections.Generic;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace ThreatLocker.Shared.Models.NamedLocation
{
    public class IPNamedLocation : NamedLocation
    {
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; } = "#microsoft.graph.ipNamedLocation";
        [JsonPropertyName("isTrusted")]
        [DefaultValue(true)]
        public bool IsTrusted { get; set; } = true;
        [JsonPropertyName("ipRanges")]
        public List<IPRange> IPRanges { get; set; }
    }

    public class IPRange
    {
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; } = "#microsoft.graph.iPv4CidrRange";
        [JsonPropertyName("cidrAddress")]
        public string CidrAddress { get; set; }
    }
}
