using System;
using System.Collections.Generic;
using ThreatLockerCommon.Models;

namespace ThreatLockerCommon.DTOs
{
    public class InstallInfo
    {
        public string DownloadUrl { get; set; }
        public long FileSize { get; set; } = -1;
        public Guid ManagedOrganizationId { get; set; }
        public Guid LoggedInOrganizationId { get; set; }
        public List<ApplicationList> ApplicationList { get; set; } = new List<ApplicationList>();
    }
}
