using Newtonsoft.Json;
using System;

namespace ThreatLocker.Shared.Models
{
    public class OktaWorkforceToken
    {
        public OktaWorkforceToken()
        {

        }

        public OktaWorkforceToken(OktaWorkforceToken token)
        {
            TokenType = token.TokenType;
            ExpiresIn = token.ExpiresIn;
            AccessToken = token.AccessToken;
            Scope = token.Scope;
            ExpirationDate = DateTime.UtcNow.AddSeconds(token.ExpiresIn - 60);
        }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; } = "okta.groups.read";

        public DateTime ExpirationDate { get; set; }
    }
}
