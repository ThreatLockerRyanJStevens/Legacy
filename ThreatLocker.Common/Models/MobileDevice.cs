using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    [Serializable]
    public class MobileDevice
    {
        public string MobileDeviceId { get; set; }
        public DateTime DateAdded { get; set; }
        public string OrganizationId { get; set; }
        public string UserId { get; set; }
        public string CellNumber { get; set; }
        public string AuthUser { get; set; }
        public string AuthKey { get; set; }
        public DateTime? LastSync { get; set; }
        public int Status { get; set; }
    }
    public class MobileDeviceSetting
    {
        public string DeviceToken { get; set; }
        public string PreviousDeviceToken { get; set; }
        public string DeviceOperatingSystem { get; set; }
        public List<string> LocalIPAddresses { get; set; } = new List<string>();
        public Guid PreviousUserId { get; set; }
    }
}
