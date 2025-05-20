using System;

namespace ThreatLocker.Shared.Models
{
    public class EULALog
    {
        public long EULALogId { get; set; }

        public string AcceptedBy { get; set; }

        public DateTime AcceptedDate { get; set; }

        public string IPAddress { get; set; }

    }
}
