using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Models
{
    public class ThreatLockerPermission
    {
        public Guid ThreatLockerPermissionId { get; set; }

        public Guid OrganizationId { get; set; }

        public int SolutionsEngineer { get; set; }

        public int CyberHero { get; set; }
    }
}
