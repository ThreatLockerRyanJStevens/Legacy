using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class DownloadInstallerType
    {
        public static readonly DownloadInstallerType Stub = new(0, "stub", "Stub Installer");
        public static readonly DownloadInstallerType MSI = new(1, "windows", "MSI Installer");
        public static readonly DownloadInstallerType PowerShell = new(2, "pssscript", "PowerShell Script");
        public static readonly DownloadInstallerType PKG = new(3, "mac", "PKG File");
        public static readonly DownloadInstallerType Remediator = new(4, "remediation", "Remediator Service Installer");
        public static readonly DownloadInstallerType WindowsXP = new(5, "windowsxp", "Windows XP Installer");
        public static readonly DownloadInstallerType Deb = new(6, "debian", "Debian Linux Agent");
        public static readonly DownloadInstallerType RPM = new(7, "redhat", "Red Hat Linux Agent");


        public DownloadInstallerType(int id, string value, string name)
        {
            Id = id;
            Value = value;
            Name = name;
        }

        public int Id { get; }
        public string Value { get; }
        public string Name { get; }

        public static readonly DownloadInstallerType[] All =
        {
            Stub,
            MSI,
            PowerShell,
            PKG,
            Remediator,
            WindowsXP,
            Deb,
            RPM
        };

        public static DownloadInstallerType Find(string value)
        {
            return All.FirstOrDefault(x => x.Value == value);
        }

        public static DownloadInstallerType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }

        public static DownloadInstallerType FindById(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }
    }
}
