using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class HelpDeskStatusOverdueType
    {
        public static readonly HelpDeskStatusOverdueType Regular = new HelpDeskStatusOverdueType(1, "Regular");
        public static readonly HelpDeskStatusOverdueType Warning = new HelpDeskStatusOverdueType(2, "Warning");
        public static readonly HelpDeskStatusOverdueType Overdue = new HelpDeskStatusOverdueType(3, "Overdue");

        public HelpDeskStatusOverdueType(int value, string name)
        {
            Value = value;
            Name = name;
        }

        public int Value { get; set; }
        public string Name { get; set; }

        public static readonly HelpDeskStatusOverdueType[] All =
       {
            Regular,
            Warning,
            Overdue
        };

        public static HelpDeskStatusOverdueType Find(int value)
        {
            return All.FirstOrDefault(x => x.Value == value);
        }

        public static HelpDeskStatusOverdueType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
