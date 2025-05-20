using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class ReportType
    {
        public static readonly ReportType Organization = new ReportType(1, "Organization");
        public static readonly ReportType ThreatLocker = new ReportType(2, "ThreatLocker");
        public static readonly ReportType TL = new ReportType(3, "TL");
        public static readonly ReportType ComputerCheckin = new ReportType(4, "ComputerCheckin");
        public static readonly ReportType Core = new ReportType(5, "Core");

        public ReportType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly ReportType[] All =
        {
            Organization,
            ThreatLocker,
            TL,
            ComputerCheckin,
            Core
        };

        //Optional Find method
        public static ReportType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        //Optional Find method
        public static ReportType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }

    }
}
