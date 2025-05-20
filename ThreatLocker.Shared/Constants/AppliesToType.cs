using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class AppliesToType
    {
        public static readonly AppliesToType None = new(0, "empty", "");
        public static readonly AppliesToType AutoComp = new(1, "autocomp", "Automatic Computer");
        public static readonly AppliesToType AutoGroup = new(2, "autogroup", "Automatic Group");
        public static readonly AppliesToType AutoSystem = new(3, "autosystem", "Automatic System");

        public AppliesToType(int id, string name, string displayName)
        {
            Id = id;
            Name = name;
            DisplayName = displayName;  
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }

        public static readonly AppliesToType[] All =
        {
            None,
            AutoComp,
            AutoGroup,
            AutoSystem
        };

        public static AppliesToType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static AppliesToType FindByName(string name)
        {
            if (!All.Any(x => x.Name == name))
                return None;

            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
