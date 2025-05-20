using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class LicenseSettingsType
    {
        public static readonly LicenseSettingsType AutomaticUsage = new LicenseSettingsType("Automatic Usage", "auto");
        public static readonly LicenseSettingsType ManualDeclaration = new LicenseSettingsType("Manual Declaration", "Manual Declaration");

        public LicenseSettingsType(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; set; }
        public string Value { get; set; }

        public static readonly LicenseSettingsType[] All =
        {
            AutomaticUsage,
            ManualDeclaration
        };

        // Optional Find method.
        public static LicenseSettingsType FindByValue(string value)
        {
            return All.FirstOrDefault(x => x.Value == value);
        }

        public static LicenseSettingsType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
