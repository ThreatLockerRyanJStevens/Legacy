using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class SubQuote
    {
        public int status { get; set; }
        public int contractLength { get; set; }
        public string cyberHeroService { get; set; }
        public string firstInvoiceDate { get; set; }
        public int invoicedSeats { get; set; }
        public string monthInvoiceDate { get; set; }
        public string monthlyInvoice { get; set; }
        public string monthlySaving { get; set; }
        public string priceDeploymentName { get; set; }
        public string pricePerSeat { get; set; }
        public Guid productId { get; set; }
        public int rampPeriod { get; set; }
        public int seatDiscountAgreementThreshold { get; set; }
        public string subquoteTotal { get; set; }
        public string totalCommitment { get; set; }
        public string validUntilDate { get; set; }
    }
}