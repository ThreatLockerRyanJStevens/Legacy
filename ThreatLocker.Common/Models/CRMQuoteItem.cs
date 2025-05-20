using System;

namespace ThreatLockerCommon.Models
{
    [Serializable]
    public class CRMQuoteItem
    {
        public Guid CrmQuoteItemId { get; set; }
        public DateTime DateCreated { get; set; }
        
        public Guid QuoteId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string Product { get; set; }
        public int MinPaidLicenses { get; set; }
        public int MaxFreeLicenses { get; set; }
        public decimal UnitCost { get; set; }
        public int FrequencyMonths { get; set; }
        public bool Autorenew { get; set; } 
        public decimal DiscountedCost { get; set; } 
        public decimal ConditionalCost { get; set; } 
        public string Currency { get; set; }
    }
}
