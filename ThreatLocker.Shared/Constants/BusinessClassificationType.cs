using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class BusinessClassificationType
    {
        public static readonly BusinessClassificationType Standard = new BusinessClassificationType(0, "Standard", 0);
        public static readonly BusinessClassificationType MSP = new BusinessClassificationType(1, "MSP", BusinessClassificationCategoryType.MSP.Id);
        public static readonly BusinessClassificationType Commercial = new BusinessClassificationType(2, "Commercial", BusinessClassificationCategoryType.Enterprise.Id);
        public static readonly BusinessClassificationType Other = new BusinessClassificationType(3, "Other", BusinessClassificationCategoryType.Enterprise.Id);
        public static readonly BusinessClassificationType NotForProfit = new BusinessClassificationType(4, "Not For Profit", BusinessClassificationCategoryType.Enterprise.Id);
        public static readonly BusinessClassificationType Educational = new BusinessClassificationType(5, "Educational", BusinessClassificationCategoryType.Enterprise.Id);
        public static readonly BusinessClassificationType VAR = new BusinessClassificationType(6, "VAR", BusinessClassificationCategoryType.MSP.Id);
        public static readonly BusinessClassificationType Distribution = new BusinessClassificationType(7, "Distribution", BusinessClassificationCategoryType.MSP.Id);
        public static readonly BusinessClassificationType Consultant = new BusinessClassificationType(8, "Consultant", BusinessClassificationCategoryType.Enterprise.Id);
        public static readonly BusinessClassificationType IR = new BusinessClassificationType(9, "Incident Response", BusinessClassificationCategoryType.MSP.Id);
        public static readonly BusinessClassificationType VendorCompetitor = new BusinessClassificationType(10, "Vendor/Competitor", BusinessClassificationCategoryType.Enterprise.Id);
        public static readonly BusinessClassificationType GSA = new BusinessClassificationType(11, "GSA", BusinessClassificationCategoryType.Enterprise.Id);
        public static readonly BusinessClassificationType VendorNoncompetitor = new BusinessClassificationType(12, "Vendor/Noncompetitor", BusinessClassificationCategoryType.Enterprise.Id);
        public static readonly BusinessClassificationType NFR = new BusinessClassificationType(13, "NFR", BusinessClassificationCategoryType.MSP.Id);

        public BusinessClassificationType(int id, string name, int categoryType)
        {
            Id = id;
            Name = name;
            CategoryType = categoryType;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryType { get; set; }

        public static readonly BusinessClassificationType[] All =
        {
            Standard,
            MSP,
            Commercial,
            Other,
            NotForProfit,
            Educational,
            VAR,
            Distribution,
            Consultant,
            IR,
            VendorCompetitor,
            GSA,
            VendorNoncompetitor,
            NFR
        };

        public static readonly int[] Quotes =
        {
            Standard.Id,
            NotForProfit.Id,
            Educational.Id,
            NFR.Id
        };

        public static BusinessClassificationType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static BusinessClassificationType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }

        public static bool IsEnterprise(int id)
        {
            return Find(id)?.CategoryType == BusinessClassificationCategoryType.Enterprise.Id;
        }
    }
}
