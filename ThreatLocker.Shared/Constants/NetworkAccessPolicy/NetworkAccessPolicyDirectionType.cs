using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Constants
{
    public class NetworkAccessPolicyDirectionType
    {
        public static readonly NetworkAccessPolicyDirectionType Unknown = new NetworkAccessPolicyDirectionType(0, "Unknown");
        public static readonly NetworkAccessPolicyDirectionType Inbound = new NetworkAccessPolicyDirectionType(1, "Inbound");
        public static readonly NetworkAccessPolicyDirectionType OutBound = new NetworkAccessPolicyDirectionType(2, "OutBound");

        public NetworkAccessPolicyDirectionType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly NetworkAccessPolicyDirectionType[] All =
        {
			Unknown,
			Inbound,
			OutBound
		};

        public static readonly NetworkAccessPolicyDirectionType[] UnifiedAuditAdvancedSearchActions =
        {
			Unknown,
			Inbound,
			OutBound
		};

        public static NetworkAccessPolicyDirectionType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static NetworkAccessPolicyDirectionType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
