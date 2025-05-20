using System;

namespace ThreatLocker.Shared.Models
{
    public class AuthToken
    {
        public string AuthTokenId { get; set; }
        public string Username { get; set; }
        public Guid UserId { get; set; }
        public Guid OrganizationId { get; set; }
        public DateTime? DateTime { get; set; }
        public DateTime ExpireDateTime { get; set; }
        public int Increment { get; set; }
        public string MFACode { get; set; }
        public bool MFAVerified { get; set; }
        public string ShowUpdateContactDetailsMFA { get; set; }
        public string CountryCode { get; set; } // ISO 3166-1 alpha-2
        public bool TokenProtection { get; set; }
        public string IPAddress { get; set; }
        public bool TokenProtectionTriggered { get; set; }
    }
}
