using System;

namespace ThreatLocker.Shared.Models
{
    public class Computer
    {
        public Guid ComputerId { get; set; }

        public Guid OrganizationId { get; set; }

        public string Hostname { get; set; }

        public string Name { get; set; }

        public Guid ComputerGroupId { get; set; }

        public string OperatingSystem { get; set; }

        public DateTime DateAdded { get; set; }

        public string SID { get; set; }

        public string Manufacturer { get; set; }

        public string SN { get; set; }

        public DateTime? InstallModeDate { get; set; }

        public string AuthKey { get; set; }

        public string InstallModeUsers { get; set; }

        public int? PolicyVersion { get; set; }

        public string ThreatLockerVersion { get; set; }

        public DateTime? LastCheckin { get; set; }

        public string InstallModeAppName { get; set; }

        public bool? InstallModePermitEnd { get; set; }

        public string InstallModeCreateMethod { get; set; }

        public string InstallModeSecurityLevel { get; set; }

        public string Json { get; set; }

        public bool PendingBaseFiles { get; set; }

        public string LastCheckinIPAddress { get; set; }

        public DateTime MonitorOnlyDateTime { get; set; }

        public int DriverStatus { get; set; }

        public bool ShouldRestart { get; set; }

        public bool UploadBaseFile { get; set; }

        public DateTime InstallModeStartDate { get; set; }

        public Guid? BuildVersionId { get; set; }

        public int ProfilingMethodId { get; set; }

        public bool ShowLearningModeInTray { get; set; }

        public bool IsRemoved { get; set; }

        public string LearningModeApplicationId { get; set; }

        public Guid? LearningModeAppId { get; set; }

        public DateTime? LastVersionChange { get; set; }

        public Guid? ThreatLockerVersionId { get; set; }

        public string MakeAndModel { get; set; }

        public Guid? DriverApplicationId { get; set; }

        public bool IsUninstalled { get; set; }

        public DateTime? UninstallDate { get; set; }

        public string PromoCode { get; set; }

        public int? NACPolicyVersion { get; set; }

        public string ProxyURL { get; set; }

    }
}
