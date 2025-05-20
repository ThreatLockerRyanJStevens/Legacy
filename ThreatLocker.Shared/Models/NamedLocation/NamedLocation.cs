using System;
using System.Text.Json.Serialization;

namespace ThreatLocker.Shared.Models.NamedLocation
{
    public class NamedLocation
    {
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault | JsonIgnoreCondition.WhenWritingNull)]
        public Guid? Id { get; set; }
    }
}
