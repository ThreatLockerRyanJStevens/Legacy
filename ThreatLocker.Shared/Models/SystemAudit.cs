using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Models
{
    public class SystemAudit
    {
        public Guid SystemAuditId { get; set; }

        public DateTime DateTime { get; set; }

        public Guid OrganizationId { get; set; }

        public Guid UserId { get; set; }

        public string Username { get; set; }

        public string Action { get; set; }

        public string IPAddress { get; set; }

        public string EffectiveAction { get; set; }

        public string Details { get; set; }

        public bool? MasterViewOnly { get; set; }

        public Guid? ObjectId { get; set; }

    }
}
