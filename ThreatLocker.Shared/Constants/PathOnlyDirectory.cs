using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class PathOnlyDirectory
    {
        public static readonly PathOnlyDirectory WindowsApps = new PathOnlyDirectory(1, "C:\\Program Files\\WindowsApps\\%");

        public PathOnlyDirectory(int id, string directory)
        {
            Id = id;
            Directory = directory;
        }

        public int Id { get; set; }
        public string Directory { get; set; }

        public static readonly PathOnlyDirectory[] All =
        {
            WindowsApps
        };

        public static PathOnlyDirectory Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static PathOnlyDirectory FindByDirectory(string directory)
        {
            return All.FirstOrDefault(x => x.Directory == directory);
        }

        public static bool DirectoryExists(string directory)
        {
            return All.Any(x => x.Directory == directory);
        }
    }
}
