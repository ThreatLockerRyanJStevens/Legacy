
using System.Linq;

namespace ThreatLocker.Shared.Constants.Policy
{
    public class PolicyStatus
    {
        public static readonly PolicyStatus Active = new PolicyStatus(1, "Active");
        public static readonly PolicyStatus Deleted = new PolicyStatus(2, "Deleted");

        public PolicyStatus(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly PolicyStatus[] All =
       {
            Active,
            Deleted
       };

        public static PolicyStatus Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static PolicyStatus FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
