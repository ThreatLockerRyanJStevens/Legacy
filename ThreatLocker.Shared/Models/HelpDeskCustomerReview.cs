using System;

namespace ThreatLocker.Shared.Models
{
    public class HelpDeskCustomerReview
    {
        public Guid HelpDeskCustomerReviewId { get; set; }

        public Guid HelpDeskTicketId { get; set; }

        public DateTime? ConfirmedResolvedDate { get; set; }

        public int? TicketRatingStars { get; set; }

        public string TicketRatingComments { get; set; }

    }

}
