using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class NetworkPolicyDirection
    {
        public static readonly NetworkPolicyDirection Unknown = new NetworkPolicyDirection(0);
        public static readonly NetworkPolicyDirection Inbound = new NetworkPolicyDirection(1);
        public static readonly NetworkPolicyDirection Outbound = new NetworkPolicyDirection(2);

        public NetworkPolicyDirection(int id)
        {
            Id = id;
        }

        public int Id { get; }

        // Left out unknown, because we want to default to Inbound when calling the Find method.
        public static readonly NetworkPolicyDirection[] All =
        {
            Unknown,
            Inbound,
            Outbound,
        };

        public static NetworkPolicyDirection Find(int id)
        {
            NetworkPolicyDirection direction = All.FirstOrDefault(x => x.Id == id);

            // If direction is not found (null) or direction is unknown, we default to inbound.
            return direction?.Id == Unknown.Id ? Inbound : direction;
        }
    }
}
