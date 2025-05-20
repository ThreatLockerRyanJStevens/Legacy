using System.Linq;

namespace ThreatLocker.Shared.Constants.Tag
{
    public class TransactionTypeIdType
    {
        public static readonly TransactionTypeIdType Enabled = new TransactionTypeIdType(1, "Enabled");
        public static readonly TransactionTypeIdType Disabled = new TransactionTypeIdType(2, "Disabled");

        public TransactionTypeIdType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly TransactionTypeIdType[] All =
        {
            Enabled,
            Disabled
        };

        public static TransactionTypeIdType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static TransactionTypeIdType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name.ToLower() == name);
        }

    }
}
