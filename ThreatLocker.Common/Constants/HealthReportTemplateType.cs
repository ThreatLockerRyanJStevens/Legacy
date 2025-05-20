using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class HealthReportTemplateType
    {
        public static readonly HealthReportTemplateType MainTemplate = new HealthReportTemplateType(1, "Main Template");
        public static readonly HealthReportTemplateType PageOne = new HealthReportTemplateType(2, "PageOne");
        public static readonly HealthReportTemplateType DynamicProgressBarOne = new HealthReportTemplateType(3, "Dynamic Progress Bar - Page One");
        public static readonly HealthReportTemplateType PageTwoGraph = new HealthReportTemplateType(4, "Page Two - Graph");
        public static readonly HealthReportTemplateType ChartScript = new HealthReportTemplateType(5, "ChartScript - Page Two");
        public static readonly HealthReportTemplateType AreasForReview = new HealthReportTemplateType(6, "Areas Recommended For Review");
        public static readonly HealthReportTemplateType AreasForReviewItem = new HealthReportTemplateType(7, "Areas Recommended For Review - Item");
        public static readonly HealthReportTemplateType Footer = new HealthReportTemplateType(8, "Footer");
        public static readonly HealthReportTemplateType PageThreeSummary = new HealthReportTemplateType(9, "Page Three - Summary");
        public static readonly HealthReportTemplateType PageThreeSummaryItem = new HealthReportTemplateType(10, "Page Three - Summary Item");
        public static readonly HealthReportTemplateType PagesApplicationOverview = new HealthReportTemplateType(11, "Pages - Applications Overview");
        public static readonly HealthReportTemplateType PagesApplicationOverviewItem = new HealthReportTemplateType(12, "Pages - Applications Overview - Report Item");
        public static readonly HealthReportTemplateType Appendix = new HealthReportTemplateType(13, "Appendix");

        public HealthReportTemplateType(long id, string name)
        {
            Id = id;
            Name = name;
        }

        public long Id { get; }
        public string Name { get; }

        public static readonly HealthReportTemplateType[] All =
        {
            MainTemplate,
            PageOne,
            DynamicProgressBarOne,
            PageTwoGraph,
            ChartScript,
            AreasForReview,
            AreasForReviewItem,
            Footer,
            PageThreeSummary,
            PageThreeSummaryItem,
            PagesApplicationOverview,
            PagesApplicationOverviewItem,
            Appendix
        };

        public static HealthReportTemplateType Find(long id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static HealthReportTemplateType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
