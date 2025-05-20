using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class DetectModuleType
    {
        public static readonly DetectModuleType All = new DetectModuleType(0, "All");
        public static readonly DetectModuleType EndpointDetect = new DetectModuleType(1, "Endpoint Detect");
        public static readonly DetectModuleType CloudDetect = new DetectModuleType(2, "Cloud Detect");

        public DetectModuleType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly DetectModuleType[] AllTypes =
        {
            EndpointDetect,
            CloudDetect,
        };

        public static DetectModuleType Find(int id)
        {
            return AllTypes.FirstOrDefault(x => x.Id == id);
        }

        public static DetectModuleType FindByName(string name)
        {
            return AllTypes.FirstOrDefault(x => x.Name.ToLower() == name);
        }
    }
}
