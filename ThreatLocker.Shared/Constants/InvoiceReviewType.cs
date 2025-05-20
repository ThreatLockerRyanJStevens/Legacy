using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class InvoiceReviewType
    {
        /// <summary>
        /// None
        /// </summary>
        public static readonly InvoiceReviewType None = new InvoiceReviewType(0, "None");
        /// <summary>
        /// Invoice has a lower Total Due from previous invoice of 10% or more
        /// </summary>
        public static readonly InvoiceReviewType LowerTotalDue = new InvoiceReviewType(1, "Invoice has a lower Total Due from previous invoice of 10% or more.");
        /// <summary>
        /// Invoice has a higher Total Due from previous invoice of 250% or more
        /// </summary>
        public static readonly InvoiceReviewType HigherTotalDue = new InvoiceReviewType(2, "Invoice has a higher Total Due from previous invoice of 250% or more.");
        /// <summary>
        /// Invoice has been created from a Quote containing one or more unsatisfied conditions
        /// </summary>
        public static readonly InvoiceReviewType ConditionNotSatisfied = new InvoiceReviewType(3, "Invoice has been created from a Quote containing one or more unsatisfied conditions.");

        public InvoiceReviewType(int id, string description)
        {
            Id = id;
            Description = description;
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public static readonly InvoiceReviewType[] All =
        {
            None,
            LowerTotalDue,
            HigherTotalDue,
            ConditionNotSatisfied
        };

        public static InvoiceReviewType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }
    }
}
