using System.Linq;

namespace ThreatLocker.Shared.Constants.CRMEvent
{
    public class EventLocationType
    {
        public static readonly EventLocationType InPerson = new EventLocationType(1, "In-Person");
        public static readonly EventLocationType Virtual = new EventLocationType(2, "Virtual");

        public EventLocationType(short id, string name)
        {
            Id = id;
            Name = name;
        }

        public short Id { get; set; }
        public string Name { get; set; }

        public static readonly EventLocationType[] All =
        {
            InPerson,
            Virtual
        };

        public static EventLocationType Find(short id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static EventLocationType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
