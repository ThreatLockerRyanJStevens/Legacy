namespace ThreatLocker.Shared.Models
{
    public class OktaWorkforceConfiguration
    {
        public int AuthenticationType { get; set;  }
        public string ApiToken { get; set;  }
        public string ClientId { get; set;  }
        public string JwkPublicKey { get; set; }
        public string JwkPrivateKey { get; set; }
        public string DpopPublicKey { get; set; }
        public string DpopPrivateKey { get; set; }
        public string DpopNonce { get; set; }
        public string DpopAth { get; set; }
        public OktaWorkforceToken AuthenticationToken { get; set; }
    }
}
