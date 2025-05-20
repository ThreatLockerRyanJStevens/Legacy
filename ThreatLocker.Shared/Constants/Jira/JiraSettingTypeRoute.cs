using System.Collections.Generic;
using System.Linq;

namespace ThreatLocker.Shared.Constants.Jira
{
    public class JiraSettingTypeRoute
    {
        public static readonly JiraSettingTypeRoute OperatingSystemRoute = new(1, "OperatingSystemRoute");
        public static readonly JiraSettingTypeRoute IssueTypeRoute = new(2, "IssueTypeRoute");
        public static readonly JiraSettingTypeRoute AffectedVersionRoute = new(3, "AffectedVersionRoute");
        public static readonly JiraSettingTypeRoute LabelRoute = new(4, "LabelRoute");
        public static readonly JiraSettingTypeRoute CommentRoute = new(5, "CommentRoute");
        public static readonly JiraSettingTypeRoute CreateIssueRoute = new(6, "CreateIssueRoute");
        public static readonly JiraSettingTypeRoute AttachmentRoute = new(7, "AttachmentRoute");

        public JiraSettingTypeRoute(int value, string name)
        {
            Value = value;
            Name = name;
        }

        public int Value { get; set; }
        public string Name { get; set; }

        public static readonly JiraSettingTypeRoute[] All =
        {
            OperatingSystemRoute,
            IssueTypeRoute,
            AffectedVersionRoute,
            LabelRoute,
            CommentRoute,
            CreateIssueRoute,
            AttachmentRoute
        };

        public static List<string> GetAllLowerNames()
        {
            List<string> allNames = new();

            foreach (JiraSettingTypeRoute api in All)
            {
                allNames.Add(api.Name.ToLower());
            }

            return allNames;
        }

        public static JiraSettingTypeRoute Find(int value)
        {
            return All.FirstOrDefault(x => x.Value == value);
        }

        public static JiraSettingTypeRoute FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
