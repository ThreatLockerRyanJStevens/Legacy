using System;

namespace ThreatLockerCommon.DTOs
{
    public class AccessDevice
    {
        public Guid AccessDeviceId { get; set; }

        public Guid OrganizationId { get; set; }

        public string DeviceId { get; set; }

        public string IPAddress { get; set; }

        public string AuthKey { get; set; }

        public string FCMToken { get; set; }

        public DateTime DateCreated { get; set; }

        public string CellPhone { get; set; }

        public string EmailAddress { get; set; }

        public string DeviceOperatingSystem { get; set; }

        public Guid ComputerGroupId { get; set; }

        public string ComputerGroupName { get; set; }

        public bool? PushEnabled { get; set; }

        public bool? GeoLocationEnabled { get; set; }

        public bool? MotionEnabled { get; set; }

        public decimal? Latitude { get; set; }

        public decimal? Longitude { get; set; }

        public DateTime? LastCheckIn { get; set; }

        public ThreatLockerAccessInviteMethod InviteMethod { get; set; }

        public string InstallationInstructions { get; set; }

        public bool IsRemoved { get; set; }

        public DateTime CacheTime = DateTime.UtcNow;
    }

    public enum ThreatLockerAccessInviteMethod
    {
        EMAIL = 1,
        SMS
    }
}
