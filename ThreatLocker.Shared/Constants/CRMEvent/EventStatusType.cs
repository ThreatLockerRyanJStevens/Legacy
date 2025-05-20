using System.Linq;

namespace ThreatLocker.Shared.Constants.CRMEvent
{
    public class EventStatusType
    {
        public static readonly EventStatusType Tentative = new EventStatusType(0, "Tentative");
        public static readonly EventStatusType Active = new EventStatusType(1, "Active");
        public static readonly EventStatusType Concluded = new EventStatusType(2, "Concluded");
        public static readonly EventStatusType Cancelled = new EventStatusType(3, "Cancelled");

        public EventStatusType(short id, string name)
        {
            Id = id;
            Name = name;
        }

        public short Id { get; set; }
        public string Name { get; set; }

        public static readonly EventStatusType[] All =
        {
            Tentative,
            Active,
            Concluded,
            Cancelled
        };

        public static EventStatusType Find(short id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static EventStatusType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
