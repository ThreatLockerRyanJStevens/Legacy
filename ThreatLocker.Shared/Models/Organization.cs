using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Models
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

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string Website { get; set; }

        public string ZipCode { get; set; }

        public int Status { get; set; }

        public string TrayIcon { get; set; }

        public string LicenseBreakdown { get; set; }

        public bool SplunkEnabled { get; set; }

        public string OrgSecurity { get; set; }

        public bool ItarCompliant { get; set; }

        public int? InstalledComputers { get; set; }

        public Guid? ThreatLockerDataCenterId { get; set; }

        public bool AllowKillRunningProcesses { get; set; }

        public int? SecuredComputers { get; set; }

        public int BusinessClassification { get; set; }

        public int NACPolicyVersion { get; set; }

        public Guid? OrganizationOwnerId { get; set; }

        public bool? AllowSSO { get; set; }

        public DateTime? TrialExpiration { get; set; }

        public DateTime? DefaultTrialExpiration { get; set; }

        public bool? RequiresOnboarding { get; set; }

    }
}
