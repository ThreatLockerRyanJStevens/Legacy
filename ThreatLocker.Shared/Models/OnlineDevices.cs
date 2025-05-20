using System;

namespace ThreatLocker.Shared.Models
{
    public class OnlineDevices
    {
        public Guid OnlineDeviceId { get; set; }

        public string Hostname { get; set; }

        public DateTime FirstSeen { get; set; }

        public DateTime LastSeen { get; set; }

        public Guid ComputerId { get; set; }

    }
}
