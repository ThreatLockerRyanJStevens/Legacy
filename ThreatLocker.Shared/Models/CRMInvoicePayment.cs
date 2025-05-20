using System;

namespace ThreatLocker.Shared.Models
{
    public class CRMInvoicePayment
    {
        public Guid CRMInvoicePaymentId { get; set; }

        public Guid CRMInvoiceId { get; set; }

        public decimal AmountPaid { get; set; }

        public string ReferenceId { get; set; }

        public string PaymentMethod { get; set; }

        public DateTime DateTime { get; set; }

        public string Currency { get; set; }

        public int PaymentStatus { get; set; }
    }
}
