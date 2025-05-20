using System.Linq;

namespace ThreatLocker.Shared.Constants.VDI
{
    public class VDIMachineStatusType
    {
        public static readonly VDIMachineStatusType Inactive = new VDIMachineStatusType("Inactive", 0);
        public static readonly VDIMachineStatusType Ready = new VDIMachineStatusType("Ready", 1);
        public static readonly VDIMachineStatusType InUse = new VDIMachineStatusType("In Use", 2);
        public static readonly VDIMachineStatusType RecyclingAndMerging = new VDIMachineStatusType("Recycling and Merging", 3);
        public static readonly VDIMachineStatusType RecyclingAndDiscarding = new VDIMachineStatusType("Recycling and Discarding", 4);

        public VDIMachineStatusType(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly VDIMachineStatusType[] All =
        {
            Ready,
            InUse,
            RecyclingAndMerging,
            RecyclingAndDiscarding
        };

        //Optional Find method
        public static VDIMachineStatusType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        //Optional Find method
        public static VDIMachineStatusType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
