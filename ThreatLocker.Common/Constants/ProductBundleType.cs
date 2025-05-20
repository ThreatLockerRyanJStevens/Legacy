using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class ProductBundleType
    {
        public static readonly ProductBundleType ThreatLockerUnified = new ProductBundleType(1, "ThreatLocker Unified", "tlunified");
        public static readonly ProductBundleType ThreatLockerProtect = new ProductBundleType(2, "ThreatLocker Protect", "tlprotect");
        public static readonly ProductBundleType ThreatLockerChoice = new ProductBundleType(3, "ThreatLocker Choice", "tlchoice");

        public ProductBundleType(int id, string name, string productName)
        {
            Id = id;
            Name = name;
            ProductName = productName;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ProductName { get; set; }

        public static readonly ProductBundleType[] All =
        {
            ThreatLockerUnified,
            ThreatLockerProtect,
            ThreatLockerChoice
        };

        //Optional Find method
        public static ProductBundleType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static ProductBundleType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name.Equals(name, System.StringComparison.OrdinalIgnoreCase));
        }

        public static ProductBundleType FindByProductName(string product)
        {
            return All.FirstOrDefault(x => x.ProductName.Equals(product, System.StringComparison.OrdinalIgnoreCase));
        }
    }
}
