using System.Linq;
using ThreatLocker.Framework.Extensions;

namespace ThreatLocker.Shared.Constants
{
    public class ConfigurationType
    {
        public static readonly ConfigurationType CyberHeroResponseSettings = new ConfigurationType(1, "Cyber Hero Response Settings");
        public static readonly ConfigurationType LocalAdminSettings = new ConfigurationType(2, "Local Admin Settings");
        public static readonly ConfigurationType DomainNameParsing = new ConfigurationType(3, "Domain Name Parsing Settings");
        public static readonly ConfigurationType CyberHeroCloudResponse = new ConfigurationType(4, "Cyber Hero Cloud Response Settings");
        public ConfigurationType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static ConfigurationType[] All =
        {
            CyberHeroResponseSettings,
            LocalAdminSettings,
            DomainNameParsing,
            CyberHeroCloudResponse,
        };

        public static string GetName(int configurationTypeId)
        {
            return (All.FirstOrDefault(x => x.Id == configurationTypeId)?.Name).ToSafeString();
        }
    }
}
