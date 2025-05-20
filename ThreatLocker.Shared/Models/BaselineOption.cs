using System;

namespace ThreatLocker.Shared.Models
{
    public class BaselineOption
    {
        public Guid BaselineOptionId { get; set; }
        public Guid EntityId { get; set; }
        public int EntityType { get; set; }
        public int OSType { get; set; }
        public string Value { get; set; }
        public DateTime DateAdded { get; set; }
        public string AddedBy { get; set; }
    }
}
