using System;

namespace ThreatLockerCommon.DTOs
{
    public class AccessDeviceRegisterDto
    {
        public Guid AccessDeviceId { get; set; }
        public string DeviceOperatingSystem { get; set; }
        public Guid ComputerGroupId { get; set; }
        public Guid OrganizationId { get; set; }
        public string DeviceId { get; set; }
        public string SHA256 { get; set; }
        public string FCMToken { get; set; }
    }
}
