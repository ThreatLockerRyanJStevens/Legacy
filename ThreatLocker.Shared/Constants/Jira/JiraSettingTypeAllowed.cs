using System.Collections.Generic;
using System.Linq;

namespace ThreatLocker.Shared.Constants.Jira
{
    public class JiraSettingTypeAllowed
    {
        public static readonly JiraSettingTypeAllowed IssueTypeAllowed = new(1, "IssueTypeAllowed");
        public static readonly JiraSettingTypeAllowed LabelAllowed = new(2, "LabelAllowed");

        public JiraSettingTypeAllowed(int value, string name)
        {
            Value = value;
            Name = name;
        }

        public int Value { get; set; }
        public string Name { get; set; }

        public static readonly JiraSettingTypeAllowed[] All =
        {
            IssueTypeAllowed,
            LabelAllowed
        };

        public static List<string> GetAllLowerNames()
        {
            List<string> allNames = new();

            foreach (JiraSettingTypeAllowed api in All)
            {
                allNames.Add(api.Name.ToLower());
            }

            return allNames;
        }

        public static JiraSettingTypeAllowed Find(int value)
        {
            return All.FirstOrDefault(x => x.Value == value);
        }

        public static JiraSettingTypeAllowed FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
