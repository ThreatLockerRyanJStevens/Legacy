using System;
using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class MobileDeviceOperatingSystemType
    {
        public static readonly MobileDeviceOperatingSystemType Android = new MobileDeviceOperatingSystemType(1, "Android");
        public static readonly MobileDeviceOperatingSystemType iOS = new MobileDeviceOperatingSystemType(2, "iOS");

        public MobileDeviceOperatingSystemType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly MobileDeviceOperatingSystemType[] All =
        {
            Android,
            iOS,
        };

        public static MobileDeviceOperatingSystemType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static MobileDeviceOperatingSystemType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
