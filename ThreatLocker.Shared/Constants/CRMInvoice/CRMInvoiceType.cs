using System.Linq;

namespace ThreatLocker.Shared.Constants.CRMInvoice
{
    public class CRMInvoiceType
    {
        public static readonly CRMInvoiceType Draft = new CRMInvoiceType(0, "Draft");
        public static readonly CRMInvoiceType Ready = new CRMInvoiceType(1, "Ready");
        public static readonly CRMInvoiceType Deleted = new CRMInvoiceType(2, "Deleted");
        public static readonly CRMInvoiceType Paid = new CRMInvoiceType(3, "Paid");
        public static readonly CRMInvoiceType PartiallyPaid = new CRMInvoiceType(4, "Partially Paid");
        public static readonly CRMInvoiceType Overdue = new CRMInvoiceType(5, "Overdue");
        public static readonly CRMInvoiceType Deferred = new CRMInvoiceType(5, "Deferred");//same Id from overdue

        public CRMInvoiceType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly CRMInvoiceType[] All =
        {
            Draft,
            Ready,
            Deleted,
            Paid,
            PartiallyPaid,
            Overdue,
            Deferred
        };

        public static readonly int[] ReadyOrPaid =
        {
            Ready.Id,
            Paid.Id
        };

        public static readonly int[] DraftDeletedPaid =
        {
            Draft.Id,
            Deleted.Id,
            Paid.Id
        };

        public static CRMInvoiceType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static CRMInvoiceType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
