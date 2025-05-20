using System;

namespace ThreatLocker.Shared.Models
{
    public class EventLog
    {
        public long EventLogId { get; set; }

        public Guid OrganizationId { get; set; }

        public DateTime? DateTime { get; set; }

        public string Details { get; set; }

    }

}
