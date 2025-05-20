using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class ComputerOrderByType
    {
        public static readonly ComputerOrderByType Action = new ComputerOrderByType(1, "action");
        public static readonly ComputerOrderByType LastCheckin = new ComputerOrderByType(2, "lastcheckin");
        public static readonly ComputerOrderByType ComputerInstallDate = new ComputerOrderByType(3, "computerinstalldate");
        public static readonly ComputerOrderByType ThreatLockerVersion = new ComputerOrderByType(4, "threatlockerversion");
        public static readonly ComputerOrderByType DeniedCountThreeDays = new ComputerOrderByType(5, "deniedcountthreedays");

        public ComputerOrderByType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly ComputerOrderByType[] All =
        {
            Action,
            LastCheckin,
            ComputerInstallDate,
            ThreatLockerVersion
        };

        public static readonly string[] OrderOnProcedure =
        {
            Action.Name,
            LastCheckin.Name,
            ComputerInstallDate.Name,
            ThreatLockerVersion.Name,
            DeniedCountThreeDays.Name
        };

        public static ComputerOrderByType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static ComputerOrderByType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
