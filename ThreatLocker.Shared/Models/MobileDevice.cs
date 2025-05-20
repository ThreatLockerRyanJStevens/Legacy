using System;

namespace ThreatLocker.Shared.Models
{
    public class MobileDevice
    {
        public string CellNumber { get; set; }
        public Guid MobileDeviceId { get; set; }

        public DateTime DateAdded { get; set; }

        public Guid OrganizationId { get; set; }

        public Guid UserId { get; set; }

        public string AuthUser { get; set; }

        public string AuthKey { get; set; }

        public DateTime? LastSync { get; set; }

        public int Status { get; set; }
    }
}
