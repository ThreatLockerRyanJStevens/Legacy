using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Models
{
    public class MacPolicy
    {
        public Guid MacPolicyId { get; set; }

        public Guid OrganizationId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string TicketInfo { get; set; }

        public string Requestor { get; set; }

        public string Comments { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool NeverExpires { get; set; }

        public Guid AppliesToId { get; set; }

        public int PolicyActionId { get; set; }

        public int OrderBy { get; set; }

        public Guid? ApplicationId { get; set; }

        public string DeviceSerialNumbers { get; set; }

        public string DeviceType { get; set; }

        public string PolicyType { get; set; }

        public bool IsEnabled { get; set; }

        public DateTime? LastMatchDateTime { get; set; }

        public int MonitorMode { get; set; }

        public int Status { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string Json { get; set; }

        public bool? LogAction { get; set; }
    }
}
