using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class UpdateChannelType
    {
        public static readonly UpdateChannelType ManualUpdate = new UpdateChannelType(0, "Manual Update");
        public static readonly UpdateChannelType PreReleases = new UpdateChannelType(1, "Pre-Releases");
        public static readonly UpdateChannelType Regular = new UpdateChannelType(2, "Regular");
        public static readonly UpdateChannelType Expediated = new UpdateChannelType(3, "Expedited");
        public static readonly UpdateChannelType SlowAndSteady = new UpdateChannelType(4, "Slow and Steady");

        public UpdateChannelType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly UpdateChannelType[] All =
        {
            ManualUpdate,
            PreReleases,
            Regular,
            Expediated,
            SlowAndSteady
        };

        public static UpdateChannelType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static UpdateChannelType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());
        }
    }
}
