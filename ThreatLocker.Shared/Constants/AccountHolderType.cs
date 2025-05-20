using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class AccountHolderType
    {
        public static readonly AccountHolderType Individual = new AccountHolderType(1, "Individual");
        public static readonly AccountHolderType Company = new AccountHolderType(2, "Company");

        public AccountHolderType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly AccountHolderType[] All =
        {
            Individual,
            Company
        };

        public static AccountHolderType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static AccountHolderType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name.ToLower() == name);
        }
    }
}
