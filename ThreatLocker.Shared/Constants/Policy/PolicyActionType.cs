using System.Linq;

namespace ThreatLocker.Shared.Constants.Policy
{
    public class PolicyActionType
    {
        public static readonly PolicyActionType Permit = new PolicyActionType(1, "Permit");
        public static readonly PolicyActionType Deny = new PolicyActionType(2, "Deny");
        public static readonly PolicyActionType Request = new PolicyActionType(3, "Request");
        public static readonly PolicyActionType InstallMode = new PolicyActionType(4, "Install Mode");
        public static readonly PolicyActionType MissingCoreFiles = new PolicyActionType(5, "Missing Core Files");
        public static readonly PolicyActionType RingFenced = new PolicyActionType(6, "RingFenced");

        public PolicyActionType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly PolicyActionType[] All =
        {
            Permit,
            Deny,
            Request,
            InstallMode,
            MissingCoreFiles,
            RingFenced
        };

        public static readonly int[] PermitTypes =
        {
            Permit.Id,
            RingFenced.Id
        };

        public static readonly int[] DenyTypes =
        {
            Deny.Id,
            Request.Id
        };

        // Optional Find method.
        public static PolicyActionType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static PolicyActionType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
