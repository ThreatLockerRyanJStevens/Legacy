using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class MaintenanceModeAppliesToType
    {
        public static readonly MaintenanceModeAppliesToType Application = new MaintenanceModeAppliesToType(0, "application");
        public static readonly MaintenanceModeAppliesToType Computer = new MaintenanceModeAppliesToType(1, "computer");
        public static readonly MaintenanceModeAppliesToType ComputerGroup = new MaintenanceModeAppliesToType(2, "group");
        public static readonly MaintenanceModeAppliesToType System = new MaintenanceModeAppliesToType(3, "system");
        
        public MaintenanceModeAppliesToType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly MaintenanceModeAppliesToType[] All =
        {
            Application,
            Computer,
            ComputerGroup,
            System
        };

        public static MaintenanceModeAppliesToType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }
    }
}
