using System.Collections.Generic;
using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class HelpDeskJiraHydrationType
    {
        public static readonly HelpDeskJiraHydrationType Link = new(1, "Link");
        public static readonly HelpDeskJiraHydrationType Create = new(2, "Create");
        public static readonly HelpDeskJiraHydrationType Both = new(3, "Both");

        public HelpDeskJiraHydrationType(int value, string name)
        {
            Value = value;
            Name = name;
        }

        public int Value { get; set; }
        public string Name { get; set; }

        public static readonly HelpDeskJiraHydrationType[] All =
        {
            Link,
            Create,
            Both
        };

        public static readonly List<HelpDeskJiraHydrationType> LinkOrBoth = new()
        {
            Link,
            Both
        };

        public static readonly List<HelpDeskJiraHydrationType> CreateOrBoth = new()
        {
            Create,
            Both
        };

        public static HelpDeskJiraHydrationType Find(int value)
        {
            return All.FirstOrDefault(x => x.Value == value);
        }

        public static HelpDeskJiraHydrationType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());
        }
    }
}
