using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
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
		public string MakeAndModel { get; set; }
		public int OSType { get; set; }
	}

	[Serializable]
	public class ComputerDenyCount
    {
		public Guid ComputerId { get; set; }
		public int OneDay { get; set; }
		public int ThreeDays { get; set; }
		public int SevenDays { get; set; }
    }
	[Serializable]
	public class OrganizationDenyCount
    {
		public Guid OrganizationId { get; set; }
		public int OneDay { get; set; }
		public int ThreeDays { get; set; }
		public int SevenDays { get; set; }
	}

	public class MobileComputerList
    {
		public int ComputerCount { get; set; }
		public List<MobileAppComputer> Computers = new List<MobileAppComputer>();
    }

	public class MobileAppComputer
    {
		public string Name { get; set; }
		public string OrganizationName { get; set; }
		public DateTime? LastCheckin { get; set; }
		public List<string> Status = new List<string>();
		public bool Elevation { get; set; }
		public bool Learning { get; set; }
		public Guid ComputerId { get; set; }
		public Guid OrganizationId { get; set; }
		public Guid ComputerGroupId { get; set; }
		public string ComputerGroupName { get; set; }
		public string TLVersion { get; set; }

	}

	public class ComputerDatabase
    {
		public Guid ComputerId { get; set; }
		public string AuthKey { get; set; }
		public string DatabaseName { get; set; }
		public string APIURL { get; set; }
    }
    public class ComputerCheckin
    {
        public string OrganizationId { get; set; }
        public string ComputerId { get; set; }
        public DateTime DateTime { get; set; }
        public long MemoryUsage { get; set; }
        public string IPAddress { get; set; }
        public int DriverStatus { get; set; }
        public string OperatingSystem { get; set; } = string.Empty;
        public int CoreCount { get; set; } = -1;
        public string TLVersion { get; set; } = string.Empty;
    }
}
