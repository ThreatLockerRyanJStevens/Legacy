using System.Linq;

namespace ThreatLocker.Shared.Constants.CRMEvent
{
    public class EventExpenseType
    {
        public static readonly EventExpenseType Flight = new EventExpenseType(1, "Flight", "Flight Start Date", "Flight End Date", "Flight Number");
        public static readonly EventExpenseType Hotel = new EventExpenseType(2, "Hotel", "Hotel Check-In Date", "Hotel Check-Out Date", "Booking Number");

        public EventExpenseType(int id, string name, string startDateLabel, string endDateLabel, string poNumberLabel)
        {
            Id = id;
            Name = name;
            StartDateLabel = startDateLabel;
            EndDateLabel = endDateLabel;
            PONumberLabel = poNumberLabel;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string StartDateLabel { get; set; }
        public string EndDateLabel { get; set; }
        public string PONumberLabel { get; set; }

        public static readonly EventExpenseType[] All =
        {
            Flight,
            Hotel
        };

        public static EventExpenseType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static EventExpenseType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
