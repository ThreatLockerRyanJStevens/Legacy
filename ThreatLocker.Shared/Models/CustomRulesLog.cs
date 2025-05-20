using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Models
{
    public class CustomRulesLog
    {
        public long CustomRulesLogId { get; set; }

        public DateTime DateTime { get; set; }

        public Guid OrganizationId { get; set; }

        public Guid LoggedInOrganizationId { get; set; }

        public Guid ApplicationId { get; set; }

        public string CreatedBy { get; set; }

        public string Hash { get; set; }

        public string Cert { get; set; }

        public string ProcessPath { get; set; }

        public string FullPath { get; set; }

        public string Username { get; set; }

        public string AddedFrom { get; set; }

        public string HostName { get; set; }

        public string OriginalCreatedBy { get; set; }

        public string OriginalHash { get; set; }

        public string OriginalCert { get; set; }

        public string OriginalProcessPath { get; set; }

        public string OriginalFullPath { get; set; }

        public string Notes { get; set; }

        public string OriginalNotes { get; set; }

        public bool IsProcessed { get; set; }

        public Guid ApprovalRequestId { get; set; }
    }
}
