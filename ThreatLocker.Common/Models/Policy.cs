using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class Policy
    {
        public Guid PolicyID { get; set; }
        public Guid OrganizationId { get; set; }
        public string Name { get; set; } = "";
        public string Users { get; set; }
        public DateTime StartDate { get; set; } = DateTime.MinValue;
        public DateTime EndDate { get; set; } = DateTime.MinValue;
        public bool NeverExpires { get; set; }
        public Guid ComputerGroupId { get; set; }
        public int PolicyActionId { get; set; }
        public int OrderBy { get; set; }
        public Guid? ApplicationId { get; set; }
        public bool LogAction { get; set; }
        public string RequestEmailAddresses { get; set; }
        public string DeviceSerialNumbers { get; set; }
        public string DeviceType { get; set; }
        public string PolicyType { get; set; }
        public string Json { get; set; }
        public string SplunkURL { get; set; }
        public string SplunkKey { get; set; }
        public string NotifyEmail { get; set; }
        public bool RingFence { get; set; }
        public bool IsEnabled { get; set; }
        public string Description { get; set; }
        public DateTime? LastMatchDateTime { get; set; }
        public int MonitorMode { get; set; }
        public int Status { get; set; }
        public bool NotifyOnMatch { get; set; }
        public string NotifyEmailAddresses { get; set; }
        public string InstructionsToTL { get; set; }
        public bool AllowElevation { get; set; }
        public int? ElevationStatus { get; set; }
        public string TicketInfo { get; set; }
        public string Requestor { get; set; }
        public string Comments { get; set; }
        public bool KillRunningProcesses { get; set; }

        public Guid AppliesToId { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? RelatedCommunityItemId { get; set; }
    }
}
