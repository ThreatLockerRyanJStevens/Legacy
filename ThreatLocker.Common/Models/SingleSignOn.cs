using System;

namespace ThreatLockerCommon.Models
{
    public class SingleSignOn
    {
        public string Username { get; set; }
        public string Timeout { get; set; }
        public string LinkedAccountId { get; set; }
        public string Identifier { get; set; }
        public bool Success { get; set; }
        public string Response { get; set; }
    }
}
