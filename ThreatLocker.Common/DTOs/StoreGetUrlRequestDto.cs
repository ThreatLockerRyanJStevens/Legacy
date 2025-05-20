using System;

namespace ThreatLockerCommon.DTOs
{
    public class StoreGetUrlRequestDto
    {
        public Guid ComputerId { get; set; }

        public string Username { get; set; }

        public string Hostname { get; set; }

        public string Categories { get; set; }

        public bool ReturnUrl { get; set; }
    }
}
