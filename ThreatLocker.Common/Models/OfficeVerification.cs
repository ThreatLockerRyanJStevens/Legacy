using System;

namespace ThreatLockerCommon.Models
{
    public class OfficeVerification
    {
        public string Username { get; set; }
        public string Timeout { get; set; }
        public string IdToken { get; set; }
        public string Code { get; set; }
        public string ReturnUri { get; set; }
    }
}
