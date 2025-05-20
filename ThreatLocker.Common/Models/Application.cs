using System;

namespace ThreatLockerCommon.Models
{
    public class Application
    {
        public Guid ApplicationId { get; set; }
        public string Name { get; set; }
        public Guid? ApplicationFamilyId { get; set; }
        public Guid OrganizationId { get; set; }
        public string Hash { get; set; }
        public string Signature { get; set; }
        public string Path { get; set; }
        public DateTime DateCreated { get; set; }
        public string PermitLibraries { get; set; }
        public bool RequireLibraryCertificate { get; set; }
        public string InstallerHash { get; set; }
        public int AppVer { get; set; }
        public string Json { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
        public Guid? ResearchApplicationId { get; set; }
        public int OSType { get; set; } = 1;
    }

    public class OnlineApplication
    {
        public Guid ApplicationOnlineId { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid OrganizationId { get; set; }
        public int OSType { get; set; }
        public int Status { get; set; }
        public int AppVer { get; set; }       
    }
}
