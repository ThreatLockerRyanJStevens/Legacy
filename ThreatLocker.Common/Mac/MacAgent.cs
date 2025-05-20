using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using ThreatLockerCommon.Models;

namespace ThreatLockerCommon.Mac
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class MacAgent
	{
		public List<APIServer> APIServers { get; set; }
		public bool ShouldRestart { get; set; }
		public int PolicyRefreshIntervalSeconds { get; set; } = 60;
		public bool UploadBaseline { get; set; }
		public List<MaintenanceMode> MaintenanceModes { get; set; } = new List<MaintenanceMode>();
		public string UpdatePath { get; set; } = string.Empty;
		public int PolicyVersion { get; set; }
		public int StoragePolicyVersion { get; set; }
		public int NacPolicyVersion { get; set; }
		public Guid OrganizationId { get; set; }
		public List<string> Products { get; set; } = new List<string>();
        public NetworkControlChallenge NetworkControlChallenge { get; set; } = new NetworkControlChallenge();
        public List<string> OwnerObjects { get; set; }
		public List<Exclusion> Exclusions { get; set; }
        public List<string> Options { get; set; } = new List<string>();
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<ServiceActionObject> ServiceActionObjects { get; set; }
    }

    public class MacAgentAuthentication
	{
		public Guid ComputerId { get; set; }
		public string AuthKey { get; set; }
	}

	public class MacAgentAuth
	{
		public Guid ComputerId { get; set; }
		public Guid OrganizationId { get; set; }
		public DateTime CacheTime { get; set; }
		public Guid ComputerGroupId { get; set; }
	}

	public class MacComputer
    {
		public Guid OrganizationId { get; set; }
		public Guid ComputerId { get; set; }
		public string AuthKey { get; set; }
		public Guid ComputerGroupId { get; set; }
	}

	public class MacAgentCheckinInfo
	{
		public MacAgentAuth MacAgentAuth { get; set; }
		public MacComputer MacComputer { get; set; }
		public string Hostname { get; set; }
		public string IPAddress { get; set; }
		public string TLVersion { get; set; }
		public string OS { get; set; }
		public string CPU { get; set; }
		public long MemoryUsage { get; set; }
		public List<string> LocalIPAddresses { get; set; } = new List<string>();
        public string ModelIdentifier { get; set; }
    }
}
