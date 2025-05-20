using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class OSType
    {
        public static readonly OSType Windows = new OSType(1, "windows");
        public static readonly OSType Mac = new OSType(2, "mac");
        public static readonly OSType Linux = new OSType(3, "linux");
        public static readonly OSType AIX = new OSType(4, "aix");
        public static readonly OSType WindowsXP = new OSType(5, "windows xp");

        public OSType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; }

        public static implicit operator int(OSType type) => type.Id;
        public string Name { get; }

        public static readonly OSType[] All =
        {
            Windows,
            Mac,
            Linux,
            AIX,
            WindowsXP
        };

        public static OSType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id) ?? Windows;
        }

        public static OSType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name) ?? Windows;
        }
    }
}
