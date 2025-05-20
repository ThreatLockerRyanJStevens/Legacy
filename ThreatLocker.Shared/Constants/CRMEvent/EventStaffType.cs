using System.Linq;

namespace ThreatLocker.Shared.Constants.CRMEvent
{
    public class EventStaffType
    {
        public static readonly EventStaffType Organizer = new EventStaffType(1, "Organizer");
        public static readonly EventStaffType Speaker = new EventStaffType(2, "Speaker");
        public static readonly EventStaffType Attendee = new EventStaffType(3, "Attendee");

        public EventStaffType(short id, string name)
        {
            Id = id;
            Name = name;
        }

        public short Id { get; set; }
        public string Name { get; set; }

        public static readonly EventStaffType[] All =
        {
            Organizer,
            Speaker,
            Attendee
        };

        public static EventStaffType Find(short id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static EventStaffType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
