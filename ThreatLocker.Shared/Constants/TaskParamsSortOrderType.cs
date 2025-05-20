using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class TaskParamsSortOrderType
    {
        public static readonly OrderByType Oldest = new(1, "oldest");
        public static readonly OrderByType Newest = new(2, "newest");
        public static readonly OrderByType LowestPriority = new(3, "lowest");
        public static readonly OrderByType HighestPriority = new(4, "highest");

        public TaskParamsSortOrderType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly OrderByType[] All =
        {
            Oldest,
            Newest,
            LowestPriority,
            HighestPriority
        };

        public static OrderByType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static OrderByType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}