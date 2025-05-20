using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class BusinessClassificationType
    {
        public static readonly BusinessClassificationType Standard = new BusinessClassificationType(0, "Standard");
        public static readonly BusinessClassificationType MSP = new BusinessClassificationType(1, "MSP");
        public static readonly BusinessClassificationType Commercial = new BusinessClassificationType(2, "Commercial");
        public static readonly BusinessClassificationType Other = new BusinessClassificationType(3, "Other");
        public static readonly BusinessClassificationType NotForProfit = new BusinessClassificationType(4, "Not For Profit");
        public static readonly BusinessClassificationType Educational = new BusinessClassificationType(5, "Educational");
        public static readonly BusinessClassificationType NFR = new BusinessClassificationType(13, "NFR");

        public BusinessClassificationType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly BusinessClassificationType[] All =
        {
            Standard,
            MSP,
            Commercial,
            Other,
            NotForProfit,
            Educational,
            NFR
        };

        public static readonly BusinessClassificationType[] Quotes =
        {
            Standard,
            NotForProfit,
            Educational,
            NFR
        };

        public static readonly int[] AppendedTypes =
        {
            Standard.Id
        };

        public static BusinessClassificationType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static BusinessClassificationType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}