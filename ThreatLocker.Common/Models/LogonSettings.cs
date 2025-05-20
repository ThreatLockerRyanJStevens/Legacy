using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class LogonSettings
    {
        public Guid LogonSettingsId { get; set; }

        public Guid ObjectId { get; set; }

        public int Priority { get; set; }

        public string MFAMethods { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public bool IsActive { get; set; }

        public int? Inactivity { get; set; }
    }

    public class LogonSettingsUser : LogonSettings
    {
        public string Username { get; set; }
    }
}
