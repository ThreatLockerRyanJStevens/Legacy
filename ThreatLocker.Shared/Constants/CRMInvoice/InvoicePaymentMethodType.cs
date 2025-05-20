using System.Linq;

namespace ThreatLocker.Shared.Constants.CRMInvoice
{
    public class InvoicePaymentMethodType
    {
        public static readonly InvoicePaymentMethodType StripeCard = new InvoicePaymentMethodType(1, "stripecard");
        public static readonly InvoicePaymentMethodType ACH = new InvoicePaymentMethodType(2, "ach");

        public InvoicePaymentMethodType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly InvoicePaymentMethodType[] All =
        {
            StripeCard,
            ACH
        };

        public static InvoicePaymentMethodType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static InvoicePaymentMethodType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
