using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class MobileDeviceStatusType
    {
        public static readonly MobileDeviceStatusType Active = new MobileDeviceStatusType(1, "Active");
        public static readonly MobileDeviceStatusType Deleted = new MobileDeviceStatusType(2, "Deleted");

        public MobileDeviceStatusType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly MobileDeviceStatusType[] All =
        {
            Active,
            Deleted
        };

        // Optional Find method.
        public static MobileDeviceStatusType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

    }
}
