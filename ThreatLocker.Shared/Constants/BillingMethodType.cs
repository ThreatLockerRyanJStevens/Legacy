using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class BillingMethodType
    {
        public static readonly BillingMethodType Device = new BillingMethodType(1, "device");
        public static readonly BillingMethodType User = new BillingMethodType(2, "user");

        public BillingMethodType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly BillingMethodType[] All =
        {
            Device,
            User
        };

        public static BillingMethodType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static BillingMethodType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
