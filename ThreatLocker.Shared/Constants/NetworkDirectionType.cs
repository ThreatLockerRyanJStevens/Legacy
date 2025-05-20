using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class NetworkDirectionType
    {
        public static readonly NetworkDirectionType Unknown = new NetworkDirectionType(0, "Unknown");
        public static readonly NetworkDirectionType Inbound = new NetworkDirectionType(1, "Inbound");
        public static readonly NetworkDirectionType Outbound = new NetworkDirectionType(2, "Outbound");

        public NetworkDirectionType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly NetworkDirectionType[] All =
        {
            Unknown,
            Inbound,
            Outbound
        };

        // Optional Find method.
        public static NetworkDirectionType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }
    }
}
