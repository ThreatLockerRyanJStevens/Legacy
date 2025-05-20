using System;

namespace ThreatLocker.Shared.Models
{
    public class ThreatLockerVersion
    {
        public Guid ThreatLockerVersionId { get; set; }

        public int MainVersion { get; set; }

        public string Description { get; set; }

        public string URL { get; set; }

        public string LocalPath { get; set; }

        public DateTime DateTime { get; set; }

        public bool IsDefault { get; set; }

        public bool IsEnabled { get; set; }

        public string OS { get; set; }

        public int OSType { get; set; }

    }
}
