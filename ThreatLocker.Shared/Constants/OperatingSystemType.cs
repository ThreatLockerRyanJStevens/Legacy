using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class OperatingSystemType
    {
        public static readonly OperatingSystemType Any = new OperatingSystemType(0, "Any");
        public static readonly OperatingSystemType Windows = new OperatingSystemType(1, "Windows");
        public static readonly OperatingSystemType macOS = new OperatingSystemType(2, "macOS");
        public static readonly OperatingSystemType Linux = new OperatingSystemType(3, "linux");
        public static readonly OperatingSystemType Aix = new OperatingSystemType(4, "AIX");
        public static readonly OperatingSystemType WindowsXP = new OperatingSystemType(5, "Windows XP");

        public OperatingSystemType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; }
        public string Name { get; }

        public static readonly OperatingSystemType[] All =
        {
            Windows, 
            macOS, 
            Linux,
            Aix,
            WindowsXP
        };

        // Optional Find method.
        public static OperatingSystemType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }
    }
}
