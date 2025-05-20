using System.Linq;

namespace ThreatLocker.Shared.Constants.CustomBannerMessage
{
    public class CustomBannerSeverityType
    {
        public static readonly CustomBannerSeverityType Information = new CustomBannerSeverityType(1, "Information");
        public static readonly CustomBannerSeverityType Warning = new CustomBannerSeverityType(2, "Warning");
        public static readonly CustomBannerSeverityType Severe = new CustomBannerSeverityType(3, "Severe");

        public CustomBannerSeverityType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly CustomBannerSeverityType[] All =
        {
            Information,
            Warning,
            Severe
        };

        public static CustomBannerSeverityType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static CustomBannerSeverityType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
