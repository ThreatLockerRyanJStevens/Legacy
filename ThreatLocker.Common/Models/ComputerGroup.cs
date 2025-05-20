using System;

namespace ThreatLockerCommon.Models
{
    public class ComputerGroupV2
    {
        public Guid ComputerGroupId { get; set; }
        public Guid OrganizationId { get; set; }
        public string Name { get; set; }
        public string InstallKey { get; set; }
        public int AutoCreatePolicies { get; set; }
        public int InitialMonitorModeHours { get; set; }
        public bool ShowLibrariesInTray { get; set; }  // discontinued 5.31
        public int PolicyRefreshIntervalSeconds { get; set; }
        public string ExcludeProcesses { get; set; }
        public bool CyberHeroUseOrgSettings { get; set; }
        public string TLInstructions { get; set; }
        public string ProxyURL { get; set; }
        public int PreventStop { get; set; }
        public string AppName { get; set; }
        public string LogoURL { get; set; }
        public string TrayIcon { get; set; }
    }

    public class CustomerTemplateGroup
    {
        public Guid ComputerGroupId { get; set; }
        public Guid OrganizationId { get; set; }
    }
}
