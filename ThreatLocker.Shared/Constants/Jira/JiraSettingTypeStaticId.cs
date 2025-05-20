using System.Collections.Generic;
using System.Linq;

namespace ThreatLocker.Shared.Constants.Jira
{
    public class JiraSettingTypeStaticId
    {
        public static readonly JiraSettingTypeStaticId SoftwareDevelopmentProjectId = new(1, "SoftwareDevelopmentProjectId");
        public static readonly JiraSettingTypeStaticId BacklogStatusId = new(2, "BacklogStatusId");
        public static readonly JiraSettingTypeStaticId HelpDeskComponentId = new(3, "HelpDeskComponentId");
        public static readonly JiraSettingTypeStaticId ReporterId = new(4, "ReporterId");
        public static readonly JiraSettingTypeStaticId AffectedVersionId = new(5, "AffectedVersionId");

        public JiraSettingTypeStaticId(int value, string name)
        {
            Value = value;
            Name = name;
        }

        public int Value { get; set; }
        public string Name { get; set; }

        public static readonly JiraSettingTypeStaticId[] All =
        {
            SoftwareDevelopmentProjectId,
            BacklogStatusId,
            HelpDeskComponentId,
            ReporterId,
            AffectedVersionId
        };

        public static List<string> GetAllLowerNames()
        {
            List<string> allNames = new();

            foreach (JiraSettingTypeStaticId api in All)
            {
                allNames.Add(api.Name.ToLower());
            }

            return allNames;
        }

        public static JiraSettingTypeStaticId Find(int value)
        {
            return All.FirstOrDefault(x => x.Value == value);
        }

        public static JiraSettingTypeStaticId FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
