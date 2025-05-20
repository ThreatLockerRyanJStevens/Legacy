using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class CRMSyncItem
    {
        public CRMSyncOrganization Organization { get; set; }
    }

    public class CRMSyncOrganization
    {
        public Guid OrganizationId { get; set; }
        public string DisplayName { get; set; }
        public string Identifier { get; set; }
        public string TimeZoneId { get; set; }
        public bool ItarCompliant { get; set; }
        public string LicenseBreakdown { get; set; }
    }

    public class SyncOrganization
    {
        public Guid OrganizationId { get; set; }
		public string Name { get; set; }
		public string DisplayName { get; set; }
		public string TimezoneId { get; set; }
		public Guid ParentId { get; set; }
		public string JSON { get; set; }
		public string AppName { get; set; }
		public string LogoURL { get; set; }
		public string TrayIcon { get; set; }
		public string OrgSecurity { get; set; }
		public bool ItarCompliant { get; set; }
		public string ProxyURL { get; set; }
		public string AuthKey { get; set; }
    }

    public class SyncUser
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string JobTitle { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string SHAPassword { get; set; }
        public Guid OrganizationId { get; set; }
        public bool Administrator { get; set; }
        public string CellPhone { get; set; }
        public bool BypassDuo { get; set; }
        public bool NotifyOnRequest { get; set; }
        public string EmailAddress { get; set; }
        public string TwoFactorMethod { get; set; }
        public string QrSecret { get; set; }
        public string PasswordlessPhoneNumber { get; set; }
        public string PasswordlessPin { get; set; }
        public bool ConfiguredMFA { get; set; }
        public int ApprovalTierLevel { get; set; }
    }

    public class SyncComputer
    {
        public Guid ComputerId { get; set; }
        public Guid OrganizationId { get; set; }
        public Guid ComputerGroupId { get; set; }
        public string AuthKey { get; set; }
        public string Hostname { get; set; }
        public string Name { get; set; }
        public string OperatingSystem { get; set; }
        public string ThreatLockerVersion { get; set; }
        public string LastCheckinIPAddress { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime LastCheckin { get; set; }
        public DateTime LastVersionChange { get; set; }
        public DateTime? UninstallDate { get; set; }
        public bool IsRemoved { get; set; }
        public bool IsUninstalled { get; set; }
    }

    public class SyncComputerTransaction
    {
        public DateTime DateTime { get; set; }
        public Guid OrganizationId { get; set; }
        public Guid ParentId { get; set; }
        public Guid ComputerId { get; set; }
        public string SalesEmail { get; set; }
        public string SalesEngineerEmail { get; set; }
        public string TransactionType { get; set; }
    }
}
