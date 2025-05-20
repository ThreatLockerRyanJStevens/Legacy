using System;
using ThreatLocker.Shared.Constants;

namespace ThreatLocker.Shared.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public Guid? ManagerId { get; set; }
        public string SHAPassword { get; set; }
        public bool IsLoggedInAsMaster { get; set; }
        public string Password { get; set; }
        public int StatusOrganization { get; set; }
        public bool? AllowSSO { get; set; }
        public bool? EnforceSSO { get; set;}
        public bool? HasPassword { get; set; }
        public int UserType { get; set; }
        public Guid OrganizationId { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Administrator { get; set; }
        public DateTime? LastLogin { get; set; }
        public string LastLoginIPAddress { get; set; }
        public bool BypassDuo { get; set; }
        public bool NotifyOnRequest { get; set; }
        public int? ApplicationNotification { get; set; }
        public int? StorageNotification { get; set; }
        public int? ElevationNotification { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public bool ContactDetailsPresent { get; set; }
        public string JobTitle { get; set; }
        public bool CanLogin { get; set; }
        public string OfficePhoneNumber { get; set; }
        public string LinkedIn { get; set; }
        public string PasswordlessPhoneNumber { get; set; }
        public string PasswordlessPin { get; set; }
        public bool HasLearnuponAccount { get; set; }
        public int? LearnuponAction { get; set; }
        public bool ConfiguredMFA { get; set; }
        public DateTime? PasswordModifyDate { get; set; }
        public int? ApprovalTierLevel { get; set; }
        public string DeviceToken { get; set; }
        public string EmailAlias { get; set; }
        public string LinkedAccount { get; set; }
        public string LinkedAccountIdentifier { get; set; }
        public bool SMSConsent { get; set; }
        public string SSOCloudInstance { get; set; }
        public string Username { get; set; }
        public string TwoFactorMethod { get; set; }
        public string QrSecret { get; set; }
        public string CellPhone { get; set; }
        public bool IsValidated { get; set; }
        public string TimeZone { get; set; }

        public string GetSSOCloudInstance()
        {
            return string.IsNullOrEmpty(SSOCloudInstance) ? AzureNationalCloudType.Global.Instance : SSOCloudInstance;
        }
    }
}
