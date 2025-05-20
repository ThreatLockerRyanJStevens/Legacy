using System.Linq;

namespace ThreatLocker.Shared.Constants.BaselineApplications
{
    public class BaselineApplications
    {
        public static readonly BaselineApplications Windows = new (1, "windows");
        public static readonly BaselineApplications Drivers = new (2, "drivers");
        public static readonly BaselineApplications Recovery = new (3, "recovery");

        public BaselineApplications(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly BaselineApplications[] All =
        {
                Windows,
                Drivers,
                Recovery
            };

        public static BaselineApplications Find(int value)
        {
            return All.FirstOrDefault(x => x.Id == value);
        }

        public static BaselineApplications FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
