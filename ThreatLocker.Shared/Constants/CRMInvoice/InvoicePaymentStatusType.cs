using System.Linq;

namespace ThreatLocker.Shared.Constants.CRMInvoice
{
    public class InvoicePaymentStatusType
    {
        public static readonly InvoicePaymentStatusType Pending = new InvoicePaymentStatusType(0, "Pending");
        public static readonly InvoicePaymentStatusType Success = new InvoicePaymentStatusType(1, "Success");
        public static readonly InvoicePaymentStatusType Failure = new InvoicePaymentStatusType(2, "Failure");

        public InvoicePaymentStatusType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly InvoicePaymentStatusType[] All =
        {
            Pending,
            Success,
            Failure
        };

        public static InvoicePaymentStatusType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static InvoicePaymentStatusType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
