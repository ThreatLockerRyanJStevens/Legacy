using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using ThreatLockerCommon.Enums;

namespace ThreatLockerCommon.Models
{
    public class ApplicationFileV2
    {
        public Guid ApplicationId { get; set; }
        public int ApplicationFileId { get; set; }
        public string FullPath { get; set; }
        public string Cert { get; set; }
        public string Hash { get; set; }
        public string ProcessPath { get; set; }
        public string InstalledBy { get; set; }
        public bool HashOnly { get; set; }
        public string ApplicationIdHash { get; set; }
    }

    public class ApplicationVersion
    {
        public Guid ApplicationId { get; set; }
        public int ApplicationFileId { get; set; }
    }

    public class ServiceActionObject
    {
        public ServiceAction Type { get; set; }
        public object Value { get; set; }
    }

    //[JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class ServiceComputerSettingV6
    {
        public List<APIServer> APIServers { get; set; } = new List<APIServer>();
        public List<APIServer> AppsAPIServers { get; set; } = new List<APIServer>();
        public List<AppSource> AppSources { get; set; } = new List<AppSource>();
        public string BrandName { get; set; } = string.Empty;
        public List<APIServer> CoreAPIServers { get; set; } = new List<APIServer>();
        public DateTime CurrentUtcTime { get; set; } = DateTime.UtcNow; //Checks for time issues on local computer
        public List<DataServer> DataServers { get; set; } = new List<DataServer>();
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Guid DriverApplicationId { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool EnableLearningFromTray { get; set; }
        public List<string> EnforceExecuteFlags { get; set; } = new List<string>();
        [JsonIgnore]
        public List<string> ExcludedPaths { get; set; } = new List<string>(); // Remove after Build-89 goes live
        public List<string> ExcludeProcesses { get; set; } = new List<string>();
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int ForceCheckUpdates { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool KillRunningProcess { get; set; }
        public string Logo { get; set; } = string.Empty;
        public List<MaintenanceMode> MaintenanceModes { get; set; } = new List<MaintenanceMode>();
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int NACPolicyVersion { get; set; }
        public List<string> Options { get; set; } = new List<string>();
        public string ORC { get; set; } = string.Empty;
        public string OrganizationId { get; set; } = string.Empty;
        public int PolicyRefreshIntervalSeconds { get; set; } = 60;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int PolicyVersion { get; set; }
        public List<string> Products { get; set; } = new List<string>();
        public string ProxyURL { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<ServiceAction> ServiceActions { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<ServiceActionObject> ServiceActionObjects { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool ShouldRestart { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int StoragePolicyVersion { get; set; }
        public string ThreatLockerDriverHash { get; set; } = string.Empty;
        public string ThreatLockerServiceHash { get; set; } = string.Empty;
        public string ThreatLockerTrayHash { get; set; } = string.Empty;
        public string TrayIcon { get; set; } = string.Empty;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int TWPolicyVersion { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int OpsPolicyVersion { get; set; }
        public string UpdatePath { get; set; } = string.Empty;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool UploadBaseFile { get; set; }
        public NetworkControlChallenge NetworkControlChallenge { get; set; } = new NetworkControlChallenge();
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> OwnerObjects { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Exclusion> Exclusions { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ProxySetting ProxySetting { get; set; }
    }

    public class NetworkControlChallenge
    {
        public bool Enabled { get; set; }
        public int Port { get; set; } = 8811;
        public int TimeoutMS { get; set; } = 1000;
    }

    public class DataServer
    {
        public string DatabaseName { get; set; }
        public string APIURL { get; set; }
    }

    public class APIServer
    {
        public string name { get; set; }
        public int cost { get; set; }
    }

    public class  APIUrl
    {
        public string Url { get; set; }
        public int Type { get; set; }
    }

    public class AppSource
    {
        public string ApiURL { get; set; }
        public Guid SourceId { get; set; }
    }

    public class ServiceTmpMaintenanceMode
    {
        public Guid MaintenanceId { get; set; }
        public string TypeDisplayName { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Users { get; set; }
        public string Application { get; set; }
        public bool PermitEnd { get; set; }
        public int AppliesToType { get; set; }
        public int MaintenanceTypeId { get; set; }
    }

    public class ServiceTmpCheckin
    {
        public string BrandName { get; set; } = string.Empty;
        public string ComputerLocalPath { get; set; } = string.Empty;
        public string ComputerName { get; set; } = string.Empty;
        public string ComputerUpdatePath { get; set; } = string.Empty;
        public DateTime DateAdded { get; set; }
        public string DotNETFramework { get; set; }
        public Guid DriverApplicationId { get; set; }
        public string ExcludedPaths { get; set; }
        public string ExcludeProcesses { get; set; }
        public int ForceCheckUpdates { get; set; } = 0;
        public string Hostname { get; set; }
        public bool IsIsolated { get; set; } = false;
        public bool IsLockedOut { get; set; } = false;
        public string LocalPath { get; set; } = string.Empty;
        public string Logo { get; set; } = string.Empty;
        public string MakeAndModel { get; set; }
        public int NACPolicyVersion { get; set; } = 0;
        public string OperatingSystem { get; set; }
        public int PolicyRefreshIntervalSeconds { get; set; } = 60;
        public int PolicyVersion { get; set; } = 0;
        public string ProxyURL { get; set; }
        public bool ShouldRestart { get; set; } = false;
        public int StoragePolicyVersion { get; set; } = 0;
        public string ThreatLockerVersion { get; set; }
        public Guid? ThreatLockerVersionId { get; set; }
        public string TrayIcon { get; set; } = string.Empty;
        public int TWPolicyVersion { get; set; } = 0;
        public int OpsPolicyVersion { get; set; } = 0;
        public string UpdatePath { get; set; } = string.Empty;
        public bool UploadBaseFile { get; set; } = false;
        public NetworkControlChallenge NetworkControlChallenge { get; set; } = new NetworkControlChallenge();
        public bool RestartComputerNeeded { get; set; }

        // Computer Serial Number (BIOS).
        public string SN { get; set; }
    }

    public class ServiceComputerCheckinData
    {
        public string OrganizationId { get; set; }
        public string ComputerId { get; set; }
        public DateTime DateTime { get; set; }
        public long MemoryUsage { get; set; }
        public string IPAddress { get; set; }
        public int DriverStatus { get; set; }
        public string OperatingSystem { get; set; }
        public bool CoreValid { get; set; }
        public string TLVersion { get; set; }
        public string DotNETFramework { get; set; }
        public bool IsIsolated { get; set; }
        public bool IsLockedOut { get; set; }
        public List<string> LocalIPAddresses { get; set; } = new List<string>();
        public bool RestartComputerNeeded { get; set; }
    }

    public class ServiceApplicationVersion
    {
        public string ApplicationId { get; set; }
        public string ApplicationFileId { get; set; }
        public long? FileCount { get; set; }
    }

    public class ServiceApplicationFileResponse
    {
        public string ApplicationId { get; set; }
        public int AppFileCount { get; set; } = 0;
        public List<ServiceAppFile> ApplicationFiles { get; set; } = new List<ServiceAppFile>();
    }
}