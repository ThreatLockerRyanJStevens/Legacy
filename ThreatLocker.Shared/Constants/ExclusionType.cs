using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class ExclusionType
    {
        public static readonly ExclusionType Execute = new ExclusionType(1, "Execute");
        public static readonly ExclusionType Install = new ExclusionType(2, "Install");
        public static readonly ExclusionType Storage = new ExclusionType(3, "Storage");

        public ExclusionType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly ExclusionType[] All =
        {
            Execute,
            Install,
            Storage
        };

        // Optional Find method.
        public static ExclusionType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }
    }
}
