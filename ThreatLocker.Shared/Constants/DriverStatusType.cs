using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class DriverStatusType
    {
        //TODO: Check Ids from 2 to end (the first one it's correct:
        public static readonly DriverStatusType Active = new DriverStatusType(1, "Active");
        public static readonly DriverStatusType DriverNeedRestart = new DriverStatusType(2, "Driver Needs Restarting");
        public static readonly DriverStatusType Offline = new DriverStatusType(3, "Offline");
        public static readonly DriverStatusType Inactive = new DriverStatusType(4, "Inactive");

        public DriverStatusType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly DriverStatusType[] All =
        {
            Active,
            DriverNeedRestart,
            Offline,
            Inactive
        };

        public static DriverStatusType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static DriverStatusType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
