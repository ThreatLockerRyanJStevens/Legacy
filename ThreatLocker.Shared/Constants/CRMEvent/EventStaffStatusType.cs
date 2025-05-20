using System.Linq;

namespace ThreatLocker.Shared.Constants.CRMEvent
{
    public class EventStaffStatusType
    {
        public static readonly EventStaffStatusType Requested = new EventStaffStatusType(0, "Requested");
        public static readonly EventStaffStatusType Approved = new EventStaffStatusType(1, "Approved");
        public static readonly EventStaffStatusType Cancelled = new EventStaffStatusType(2, "Cancelled");
        public static readonly EventStaffStatusType Registered = new EventStaffStatusType(3, "Registered");

        public EventStaffStatusType(short id, string name)
        {
            Id = id;
            Name = name;
        }

        public short Id { get; set; }
        public string Name { get; set; }

        public static readonly EventStaffStatusType[] All =
        {
            Requested,
            Approved,
            Cancelled,
            Registered
        };

        public static EventStaffStatusType Find(short id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static EventStaffStatusType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
