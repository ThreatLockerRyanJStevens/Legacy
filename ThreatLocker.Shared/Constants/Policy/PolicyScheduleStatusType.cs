
using System.Linq;

namespace ThreatLocker.Shared.Constants.Policy
{
    public class PolicyScheduleStatusType
    {
        public static readonly PolicyScheduleStatusType AlwaysOn = new PolicyScheduleStatusType(0, "Always On");
        public static readonly PolicyScheduleStatusType Expire = new PolicyScheduleStatusType(1, "Expire");
        public static readonly PolicyScheduleStatusType Schedule = new PolicyScheduleStatusType(2, "Schedule");

        public PolicyScheduleStatusType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly PolicyScheduleStatusType[] All =
       {
            AlwaysOn,
            Expire,
            Schedule
       };

        public static PolicyScheduleStatusType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static PolicyScheduleStatusType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
