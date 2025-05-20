using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class OperatingSystemType
    {
        public static readonly OperatingSystemType Windows = new OperatingSystemType(1, "Windows");
        public static readonly OperatingSystemType macOS = new OperatingSystemType(2, "macOS");
        public static readonly OperatingSystemType Linux = new OperatingSystemType(3, "Linux", true);
        public static readonly OperatingSystemType Aix = new OperatingSystemType(4, "AIX", false);
        public static readonly OperatingSystemType WindowsXP = new OperatingSystemType(5, "Windows XP", true);

        public OperatingSystemType(int id, string name, bool isActive = true)
        {
            Id = id;
            Name = name;
            IsActive = isActive;
        }

        public int Id { get; }
        public string Name { get; }
        public bool IsActive { get; }

        public static implicit operator int(OperatingSystemType type) => type.Id;

        public static readonly OperatingSystemType[] All =
        {
            Windows,
            macOS,
            Linux,
            Aix,
            WindowsXP
        };

        public static OperatingSystemType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id) ?? Windows;
        }

        public static OperatingSystemType FindByName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                return All.FirstOrDefault(x => name.ToLower().Contains(x.Name.ToLower())) ?? Windows;
            }
            else
            {
                return Windows;
            }
        }
    }
}
