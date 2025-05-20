using System.Linq;

namespace ThreatLocker.Shared.Constants.Policy
{
    public class PolicyPermissionType
    {
        public static readonly PolicyPermissionType Read = new PolicyPermissionType("read", "Read");
        public static readonly PolicyPermissionType Write = new PolicyPermissionType("write", "Write");
        public static readonly PolicyPermissionType ReadWrite = new PolicyPermissionType("", "Read/Write");

        public PolicyPermissionType(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Id { get; set; }
        public string Name { get; set; }

        public static readonly PolicyPermissionType[] All =
        {
            Read,
            Write,
        };

        // Optional Find method.
        public static PolicyPermissionType Find(string id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static PolicyPermissionType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }

        public static string FindNameByPolicyAction(string policyType, string policyAction)
        {
            if (policyAction == PolicyActionType.Permit.Name)
            {
                return policyType == Write.Id ? ReadWrite.Name : policyType == Read.Id ? Read.Name : "";
            }
            else if (policyAction == PolicyActionType.Deny.Name || policyAction == PolicyActionType.Request.Name)
            {
                return policyType == Read.Id ? ReadWrite.Name : policyType == Write.Id ? Write.Name : "";
            }
            else 
            { 
                return string.Empty; 
            }
        }
    }
}
