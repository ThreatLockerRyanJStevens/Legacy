using System;

namespace ThreatLockerCommon.Models
{
    [Serializable]
    public class User
    {
        public string OrganizationId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public string ShaPassword { get; set; }
        public bool Administrator { get; set; }
        public string CellPhone { get; set; }
        public bool BypassDuo { get; set; }
        public bool NotifyOnRequest { get; set; }
        public bool NotifyOnIgnoredRequests { get; set; } // Remove after Build-86 goes live
        public string TwoFactorMethod { get; set; }
        public string QrSecret { get; set; }
        public string PasswordlessPhoneNumber { get; set; }
        public string PasswordlessPin { get; set; }
        public string JobTitle { get; set; }
        public string EmailAddress { get; set; }
        public DateTime? LastLogin { get; set; }
        public bool ConfiguredMFA { get; set; }
        public int ApprovalTierLevel { get; set; }
        public string EmailAlias { get; set; }
    }
}
