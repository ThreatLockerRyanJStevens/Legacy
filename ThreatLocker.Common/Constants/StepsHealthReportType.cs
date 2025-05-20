using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class StepsHealthReportType
    {
        public static readonly StepsHealthReportType Report = new StepsHealthReportType(0, "Report", "#c7c8ca", "#0d80a7");
        public static readonly StepsHealthReportType Application = new StepsHealthReportType(1, "Application", "#c7c8ca", "#0d80a7");
        public static readonly StepsHealthReportType Overview = new StepsHealthReportType(2, "Overview", "#c7c8ca", "#0d80a7");
        public static readonly StepsHealthReportType Appendix = new StepsHealthReportType(3, "Appendix", "#c7c8ca", "#0d80a7");

        public StepsHealthReportType(int id, string name, string defaultColor,string currentColor)
        {
            Id = id;
            Name = name;
            DefaultColor = defaultColor;
            CurrentColor = currentColor;
        }

        public int Id { get; }
        public string Name { get; }
        public string DefaultColor { get; }
        public string CurrentColor { get; }

        public static readonly StepsHealthReportType[] All =
        {
            Report,
            Application,
            Overview,
            Appendix
        };

        public static StepsHealthReportType FindById(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static StepsHealthReportType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }

    }
}
