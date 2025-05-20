using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class ProductStatus
    {
        public static readonly ProductStatus TrialNotStarted = new ProductStatus(-1, "Trial Not Started");
        public static readonly ProductStatus TrialEnded = new ProductStatus(0, "Trial Ended");
        public static readonly ProductStatus OnTrial = new ProductStatus(1, "On Trial");
        public static readonly ProductStatus Deleted = new ProductStatus(2, "Deleted");

        public ProductStatus(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly ProductStatus[] All =
        {
            TrialNotStarted,
            TrialEnded,
			OnTrial,
            Deleted
        };

        public static ProductStatus Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static ProductStatus FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
