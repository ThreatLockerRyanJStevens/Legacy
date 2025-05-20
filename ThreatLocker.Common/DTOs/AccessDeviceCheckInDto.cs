using System;

namespace ThreatLockerCommon.DTOs
{
    public class AccessDeviceCheckInDto
    {
        public Guid AccessDeviceId { get; set; }
        public bool PushEnabled { get; set; }
        public bool GeoLocationEnabled { get; set; }
        public bool MotionEnabled { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
    }
}
