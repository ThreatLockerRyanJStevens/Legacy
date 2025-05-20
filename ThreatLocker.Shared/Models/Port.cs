using System;

namespace ThreatLocker.Shared.Models
{
    public class Port
    {
        public long PortId { get; set; }
        public string Name { get; set; }
        public int MinValue { get; set; }
        public int? MaxValue { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
