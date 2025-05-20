using System;
using System.Linq;

namespace ThreatLocker.Shared.Constants.CMPolicy
{
    public class CMPolicyStatus
    {
        public static readonly CMPolicyStatus NotConfigured = new CMPolicyStatus(-1, "Not Configured");
        public static readonly CMPolicyStatus Disabled = new CMPolicyStatus(0, "Disabled");
        public static readonly CMPolicyStatus Enabled = new CMPolicyStatus(1, "Enabled");
        public static readonly CMPolicyStatus Deleted  = new CMPolicyStatus(2, "Deleted");


        public CMPolicyStatus(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly CMPolicyStatus[] All =
       {
			NotConfigured,
			Disabled,
			Enabled,
			Deleted
	   };

        public static CMPolicyStatus Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static CMPolicyStatus FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
