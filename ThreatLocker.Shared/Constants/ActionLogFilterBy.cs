using System.Collections.Generic;
using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class ActionLogFilterBy
    {
        public static readonly ActionLogFilterBy ComputersInstalledOver4DaysAgo = new(1, "Computers installed over 4 days ago", "Computers installed over 4 days ago");
        public static readonly ActionLogFilterBy ComputersInstalledOver7DaysAgo = new(2, "Computers installed over 7 days ago", "Computers installed over 7 days ago");
        public static readonly ActionLogFilterBy RemovedWhiteNoise = new (3, "Remove White Noise", "Removed White Noise");
        public static readonly ActionLogFilterBy ComputersInMonitorOnly = new(4, "monitoronly", "Computers in Monitor Only");
        public static readonly ActionLogFilterBy ComputersInSecuredMode = new(5, "securedMode", "Computers in Secured Mode");

        public ActionLogFilterBy(int id, string value, string name)
        {
            Id = id;
            Value = value;
            Name = name;
        }

        public int Id { get; }
        public string Value { get; }
        public string Name { get; }

        public static readonly ActionLogFilterBy[] All =
       {
            ComputersInstalledOver4DaysAgo,
            ComputersInstalledOver7DaysAgo,
            RemovedWhiteNoise,
            ComputersInMonitorOnly,
            ComputersInSecuredMode
        };

        public static List<ActionLogFilterBy> GetFilters(List<string> filters)
        {
            var actionLogFilterBys = new List<ActionLogFilterBy>();

            actionLogFilterBys.AddRange(All.Where(x => filters.Contains(x.Value)));

            return actionLogFilterBys;
        }

        public static ActionLogFilterBy Find(string value)
        {
            return All.FirstOrDefault(x => x.Value == value);
        }

        public static ActionLogFilterBy FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
