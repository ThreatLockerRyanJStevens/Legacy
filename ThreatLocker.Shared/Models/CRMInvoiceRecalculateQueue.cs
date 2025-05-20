using System;

namespace ThreatLocker.Shared.Models
{
    public class CRMInvoiceRecalculateQueue
    {
        public long CRMInvoiceRecalculateQueueId { get; set; }
        public Guid OrganizationId { get; set; }
        public Guid CRMInvoiceId { get; set; }
        public DateTime DateRequested { get; set; }
        public string RequestedBy { get; set; }
        public int Status { get; set; }
    }
}
