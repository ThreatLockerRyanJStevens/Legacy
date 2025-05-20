using System.Linq;

namespace RulesEngine
{
    public class OperatingSystemType
    {
        public static readonly OperatingSystemType Windows = new OperatingSystemType(1, "Windows");
        public static readonly OperatingSystemType macOS = new OperatingSystemType(2, "macOS");
        public static readonly OperatingSystemType Linux = new OperatingSystemType(3, "linux");
        public static readonly OperatingSystemType WindowsXP = new OperatingSystemType(5, "windowsxp");

        public OperatingSystemType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly OperatingSystemType[] All =
        {
            Windows,
            macOS,
            Linux,
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
