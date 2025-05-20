using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ThreatLockerCommon.Models
{
    public class Quote
    {
        public string quoteName { get; set; }
        public Guid organizationId { get; set; }
        public Guid quoteId { get; set; }
        public DateTime expirationDate { get; set; }
        public string totalAmount { get; set; }
        public int discountPercentage { get; set; }
        public int contractLength { get; set; }
        public DateTime firstInvoiceDate { get; set; }
        public List<QuoteItem> quoteItems { get; set; }
        public DateTime creationDate { get; set; }
        public bool success { get; set; }
        public string cyberHeroService { get; set; }
        public int status { get; set; }
        public string createdBy { get; set; }
        public string customerResponseBy { get; set; }
        public DateTime customerResponseDate { get; set; }
        public bool isAccept { get; set; }
        public string emailAddress { get; set; }
        public string fullName { get; set; }
        public List<string> html { get; set; } = new List<string>();
        public string currencyCode { get; set; }
        public string digitalSignatureId { get; set; }
        public string signedStatus { get; set; }
        public string lastViewed { get; set; }
    }
    public class QuoteItem
    {
        public int status { get; set; }
        public string priceDeploymentName { get; set; }
        public string pricePerSeat { get; set; }
        public string tierName { get; set; }
        public Guid quoteItemId { get; set; }
        public string productName { get; set; }
        public int rampPeriod { get; set; }
        public int minSeatAgreementThreshold { get; set; }
        public string quoteItemTotal { get; set; }
        public string totalSeatCommitment { get; set; }
    }
}