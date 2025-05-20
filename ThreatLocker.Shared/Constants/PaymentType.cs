using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class PaymentType
    {
        public static readonly PaymentType Invoice = new PaymentType(1, "invoice");
        public static readonly PaymentType Creditcard = new PaymentType(2, "creditcard");
        public static readonly PaymentType ACH = new PaymentType(3, "ach");

        public PaymentType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly PaymentType[] All =
        {
            Invoice,
            Creditcard,
            ACH
        };

        public static readonly string[] PayNow =
        {
            Creditcard.Name,
            ACH.Name
        };

        public static PaymentType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static PaymentType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
