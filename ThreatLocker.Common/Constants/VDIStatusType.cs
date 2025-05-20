using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class VDIStatusType
    {
        public static readonly VDIStatusType None = new VDIStatusType("None", 0);
        public static readonly VDIStatusType PendingAction = new VDIStatusType("Pending Action", 1);
        public static readonly VDIStatusType Merged = new VDIStatusType("Merged", 2);
        public static readonly VDIStatusType Discarded = new VDIStatusType("Discarded", 3);

        public VDIStatusType(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly VDIStatusType[] All =
        {
            PendingAction,
            Merged,
            Discarded
        };

        //Optional Find method
        public static VDIStatusType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        //Optional Find method
        public static VDIStatusType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
