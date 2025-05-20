using System;
using System.Collections.Generic;
using ThreatLockerCommon.Enums;

namespace ThreatLockerCommon.Models
{
    public class Organization
	{
		public Guid OrganizationId { get; set; }
		public string Name { get; set; }
		public int PolicyVersion { get; set; }
		public Guid? ParentId { get; set; }
		public string OUser { get; set; }
		public string OKey { get; set; }
		public string TimezoneId { get; set; }
		public int AppVersion { get; set; }
		public bool StorageControl { get; set; }
		public bool ApplicationControl { get; set; }
		public int StoragePolicyVersion { get; set; }
		public int NACPolicyVersion { get; set; }
		public string LogoURL { get; set; }
		public string AppName { get; set; }
		public string Color1 { get; set; }
		public string Color2 { get; set; }
		public string Color3 { get; set; }
		public string PortalURL { get; set; }
		public string JSON { get; set; }
		public string DUOApiURL { get; set; }
		public string DUOIntegration { get; set; }
		public string DUOSecretKey { get; set; }
		public bool BypassDUOLastLoginIP { get; set; }
		public int OrderStatusId { get; set; }
		public string SalesEngineerEmail { get; set; }
		public string SalesEmail { get; set; }
		public DateTime DateAdded { get; set; }
		public string CompanyIdentifier { get; set; }
		public int DenyAlertCount { get; set; }
		public int DenyAlertDoubleThreshold { get; set; }
		public string BillingJson { get; set; }
		public int PendingDeploy { get; set; }
		public bool IsPartner { get; set; }
		public string DisplayName { get; set; }
		public int ActiveCount { get; set; }
		public bool IsRemoved { get; set; }
		public int TotalSeats { get; set; }
		public int TargetSeats { get; set; }
		public int ManagementLevel { get; set; }
		public string LinkedInPage { get; set; }
		public string CompanyPhone { get; set; }
		public string Logo { get; set; }
		public int? Employees { get; set; }
		public string AnnualRevenue { get; set; }
		public string ReferralCode { get; set; }
		public string ReferralType { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Country { get; set; }
		public string ZipCode { get; set; }
		public string Website { get; set; }
		public bool success { get; set; }
		public int status { get; set; }
		public Guid ThreatLockerDataCenterId { get; set; }
		public int BusinessClassification { get; set; }
		public bool RequiresOnboarding { get; set; }

	}

	public class OrganizationChild
    {
		public Guid OrganizationId { get; set; }
		public string Name { get; set; }
		public Guid ParentId { get; set; }
		public string TimezoneId { get; set; }
		public string LogoURL { get; set; }
		public string AppName { get; set; }
		public string JSON { get; set; }
		public string DisplayName { get; set; }
		public string TrayIcon { get; set; }
		public string OrgSecurity { get; set; }
		public bool ItarCompliant { get; set; }
		public string ProxyURL { get; set; }
	}

	public class OrganizationContact
	{
		public Guid OrganizationId { get; set; }
		public string OrgName { get; set; }
		public Guid ParentId { get; set; }
		public string TimezoneId { get; set; }
		public string DisplayName { get; set; }
		public string LinkedInPage { get; set; }
		public string CompanyPhone { get; set; }
		public Guid ContactId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string EmailAddress { get; set; }
		public string Title { get; set; }
		public string OfficePhone { get; set; }
		public string CellPhone { get; set; }
		public string LinkedIn { get; set; }
		public string Notes { get; set; }
		public bool Success { get; set; }
		public string Results { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Country { get; set; }
		public string ZipCode { get; set; }
		public string Website { get; set; }
		public int? Employees { get; set; }
		public string AnnualRevenue { get; set; }
		public string ReferralCode { get; set; }
		public string SalesEmail { get; set; }
		public int BusinessClassification { get; set; }
		public string Description { get; set; }
	}

	public class OrganizationAddress
    {
		public Guid OrganizationId { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Country { get; set; }
		public string ZipCode { get; set; }
    }

    public class OrganizationInvoicingDto
    {
        public Guid OrganizationId { get; set; }
        public string Name { get; set; }
		public AutomatedInvoicingStatus InvoicingStatus { get; set; }
    }

    public class OrganizationDetails
    {
		public Guid OrganizationId { get; set; }

		public string DisplayName { get; set; }

		public string Name { get; set; }

		public string ParentName { get; set; }

		public DateTime DateAdded { get; set; }

		public string Product { get; set; }

		public string BillingJson { get; set; }

		public int BusinessClassification { get; set; }

		public string LicenseSetting { get; set; } = "auto";

		public int ComputerCount { get; set; }

		public string BillingMethod { get; set; } = "device";

		public int ActiveCount { get; set; }

		public int Lockdown { get; set; }

		public int ManualCount { get; set; }

		public Boolean ITARCompliant { get; set; } = false;
		public int TotalDenyCount { get; set; }
		public int DenyCountOneDay { get; set; }
		public int DenyCountThreeDays { get; set; }
		public int DenyCountSevenDays { get; set; }

	}

	[Serializable]
	public class OrganizationSecurity
	{
		public int TwoFactorEnforcement { get; set; } //0 = off, 1 = on, 2 = on for selected
		public List<string> Allowed2FAMethods { get; set; } // used for TwoFactorEnforcement = 1
		public List<UserAllowed2FAMethods> UserAllowed2FAMethods { get; set; } // used for TwoFactorEnforcement = 2
	}

	[Serializable]
	public class UserAllowed2FAMethods
	{
		public Guid UserId { get; set; }
		public List<string> Allowed2FAMethods { get; set; }
	}

	public class OrganizationSeats
    {
		public Guid OrganizationId { get; set; }
		public int TotalSeats { get; set; }
		public int TargetSeats { get; set; }
	}

	public class OrganizationBillingContact
    {
		public Guid OrganizationBillingContactId { get; set; }
		public string SignerEmail { get; set; }
	}

	public class OrganizationDomains
	{
		public string Name { get; set; }
		public string Domain { get; set; }
		public bool Success { get; set; }
		public string Results { get; set; }
	}
}
