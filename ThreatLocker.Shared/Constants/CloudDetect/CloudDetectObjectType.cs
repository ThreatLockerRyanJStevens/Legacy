using System.ComponentModel;
using System.Linq;

namespace ThreatLocker.Shared.Constants.CloudDetect
{
    public class CloudDetectObjectType
    {
        public static readonly CloudDetectObjectType Any = new CloudDetectObjectType(0, "Any");
        public static readonly CloudDetectObjectType ThreatLockerEndpoint = new CloudDetectObjectType(1, "ThreatLocker Endpoint");
        public static readonly CloudDetectObjectType MicrosoftUser = new CloudDetectObjectType(2, "Microsoft User");
        public static readonly CloudDetectObjectType MicrosoftApp = new CloudDetectObjectType(3, "Microsoft Application");
        public static readonly CloudDetectObjectType MicrosoftTenant = new CloudDetectObjectType(4, "Microsoft Tenant");
        public static readonly CloudDetectObjectType MicrosoftSystem = new CloudDetectObjectType(5, "Microsoft System");
        public static readonly CloudDetectObjectType MicrosoftPolicy = new CloudDetectObjectType(6, "Microsoft Policy");

        public CloudDetectObjectType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly CloudDetectObjectType[] AllTypes =
        {
            Any,
            ThreatLockerEndpoint,
            MicrosoftUser,
            MicrosoftApp,
            MicrosoftTenant,
            MicrosoftSystem,
            MicrosoftPolicy,
        };

        public static readonly int[] MicrosoftTypes =
        {
            MicrosoftUser.Id,
            MicrosoftApp.Id,
            MicrosoftTenant.Id,
            MicrosoftSystem.Id,
            MicrosoftPolicy.Id,
        };

        public static CloudDetectObjectType Find(int id)
        {
            return AllTypes.FirstOrDefault(x => x.Id == id);
        }

        public static CloudDetectObjectType FindByName(string name)
        {
            return AllTypes.FirstOrDefault(x => x.Name.ToLower() == name);
        }
    }
}
