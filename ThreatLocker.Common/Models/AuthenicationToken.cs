using System;
using ThreatLockerCommon.Enums;

namespace ThreatLockerCommon.Models
{
    public class AuthenicationToken
    {
        public string AuthToken { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string OrganizationId { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public bool MFASuccess = false;
        public MFAType MFAType { get; set; }
        public DateTime ExpiryDate;
        public string TwoFactorMethod { get; set; }
        public string QrSecret { get; set; }
        public string APIURL { get; set; }
        public string PortalUrl { get; set; }
        public int Increment { get; set; }
        public string MFACode { get; set; }
        public bool ConfiguredMFA { get; set; }
        public bool EnforcedMFA { get; set; }
        public bool IsBlocked { get; set; }
    }
}
