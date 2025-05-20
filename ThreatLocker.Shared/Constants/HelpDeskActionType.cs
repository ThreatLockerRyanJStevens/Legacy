using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class HelpDeskActionType
    {
        public static readonly HelpDeskActionType Created = new HelpDeskActionType(1, "created");
        public static readonly HelpDeskActionType Added = new HelpDeskActionType(2, "added");
        public static readonly HelpDeskActionType Changed = new HelpDeskActionType(3, "changed");
        public static readonly HelpDeskActionType Deleted = new HelpDeskActionType(4, "deleted");
        public static readonly HelpDeskActionType Viewed = new HelpDeskActionType(5, "viewed");

        public HelpDeskActionType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly HelpDeskActionType[] All =
        {
            Created,
            Added,
            Changed,
            Deleted,
            Viewed
        };

        public static HelpDeskActionType Find(int value)
        {
            return All.FirstOrDefault(x => x.Id == value);
        }

        public static HelpDeskActionType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
