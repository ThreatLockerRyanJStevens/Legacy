using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class CommissionType
    {
        public static readonly CommissionType Sales = new (1, "Sales");
        public static readonly CommissionType SE = new (2, "SE");
        public static readonly CommissionType SalesLead = new (3, "Sales Lead");
        public static readonly CommissionType Support = new (4, "Support");
        public static readonly CommissionType SDRDemo = new (5, "SDR Demo");
        public static readonly CommissionType SDRLead = new (6, "SDR Lead");
        public static readonly CommissionType Accelerator = new (7, "Accelerator");

        public CommissionType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; }
        public string Name { get; }

        public static implicit operator int(CommissionType type) => type.Id;

        public static readonly CommissionType[] All =
        {
            Sales,
            SE,
            SalesLead,
            Support,
            SDRDemo,
            SDRLead,
            Accelerator
        };

        public static CommissionType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static CommissionType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
