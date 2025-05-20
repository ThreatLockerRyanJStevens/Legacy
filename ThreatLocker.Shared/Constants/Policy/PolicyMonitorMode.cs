using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Constants.Policy
{
    public class PolicyMonitorMode
    {
        public static readonly PolicyMonitorMode Inherit = new PolicyMonitorMode(0, "Inherit");
        public static readonly PolicyMonitorMode Secured = new PolicyMonitorMode(1, "Secured");
        public static readonly PolicyMonitorMode MonitorOnly = new PolicyMonitorMode(2, "Monitor Only");

        public PolicyMonitorMode(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly PolicyMonitorMode[] All =
       {
            Inherit,
            Secured,
            MonitorOnly
       };

        public static PolicyMonitorMode Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static PolicyMonitorMode FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }

    }
}
