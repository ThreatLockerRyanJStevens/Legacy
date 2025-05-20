using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class HelpDeskFileTargetType
    {
        public static readonly HelpDeskFileTargetType FromTicket = new HelpDeskFileTargetType(1, "From Ticket");
        public static readonly HelpDeskFileTargetType FromComment = new HelpDeskFileTargetType(2, "From Comment");

        public HelpDeskFileTargetType(int value, string name)
        {
            Value = value;
            Name = name;
        }

        public int Value { get; set; }
        public string Name { get; set; }

        public static readonly HelpDeskFileTargetType[] All =
       {
            FromTicket,
            FromComment
        };

        public static HelpDeskFileTargetType Find(int value)
        {
            return All.FirstOrDefault(x => x.Value == value);
        }

        public static HelpDeskFileTargetType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }

    }
}
