using Newtonsoft.Json;
using ThreatLockerCommon.Constants;
using ThreatLockerCommon.Enums;

namespace ThreatLockerCommon.Models
{
    public class RemediationCommand
    {
        public long RemediationCommandId { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int RemediationCommandStatusId { get; set; } = RemediationCommandStatus.Pending.Id;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Response { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public RemediationCommandResponseType ResponseType { get; set; }
        public string Command { get; set; }
    }
}
