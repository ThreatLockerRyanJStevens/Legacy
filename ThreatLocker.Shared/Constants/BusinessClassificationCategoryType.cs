using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class BusinessClassificationCategoryType
    {
        public static readonly BusinessClassificationCategoryType Enterprise = new BusinessClassificationCategoryType(1, "Enterprise");
        public static readonly BusinessClassificationCategoryType MSP = new BusinessClassificationCategoryType(2, "MSP");

        public BusinessClassificationCategoryType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly BusinessClassificationCategoryType[] All =
        {
            Enterprise,
            MSP
        };

        public static BusinessClassificationCategoryType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static BusinessClassificationCategoryType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
