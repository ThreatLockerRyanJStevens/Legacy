using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class AzureNationalCloudType
    {
        public static readonly AzureNationalCloudType Global = new AzureNationalCloudType(".com", "microsoftonline.com", "Global");
        public static readonly AzureNationalCloudType USGovernment = new AzureNationalCloudType(".us", "microsoftonline.us", "US Government");

        public AzureNationalCloudType(string domain, string instance, string name)
        {
            Domain = domain;
            Instance = instance;
            Name = name;
        }

        public string Domain { get; set; }
        public string Instance { get; set; }
        public string Name { get; set; }

        public static readonly AzureNationalCloudType[] All =
        {
            Global,
            USGovernment
        };

        public static AzureNationalCloudType Find(string domain)
        {
            return All.FirstOrDefault(x => x.Domain == domain);
        }

        public static AzureNationalCloudType FindByInstance(string instance)
        {
            return All.FirstOrDefault(x => x.Instance == instance);
        }

        public static AzureNationalCloudType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
