using ThreatLockerCommon.Models;

namespace ThreatLockerCommon.DTOs
{
    public class UniqueThreatLockerItemDTO
    {
        public int HashCode { get; set; }
        public ThreatLockerItemDTO Item { get; set; }
    }
}
