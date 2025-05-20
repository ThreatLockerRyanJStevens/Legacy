using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class LicenseBreakdown
    {
        public Guid OrganizationId { get; set; }
        public string LicenseType { get; set; }
        public int LicenseCount { get; set; }
        public string Products { get; set; }
    }

    public class LicenseBreakdownV2
    {
        public string DisplayName { get; set; }
        public string LicenseType { get; set; }
        public List<string> Licenses { get; set; } = new List<string>();
        public int LicenseCount { get; set; } = 0;
        public string Products { get; set; } = "No Active Products";
    }

    public class LicenseInformation
    {
        public int LicenseCount = 0;
        public List<LicenseBreakdown> Licenses = new List<LicenseBreakdown>();
    }

    public class LicenseInformationNew
    {
        public Guid OrganizationId { get; set; }
        public string LicenseBreakdown { get; set; }
        public Dictionary<int, ProductLicenseCount> LicenseCounts { get; set; } = new Dictionary<int, ProductLicenseCount>();
    }
}
