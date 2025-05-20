using System.Collections.Generic;
using System.Linq;

namespace ThreatLocker.Shared.Constants.Jira
{
    public class JiraSettingTypeCustomFieldName
    {
        public static readonly JiraSettingTypeCustomFieldName OperatingSystemCustomFieldName = new(1, "OperatingSystemCustomFieldName");
        public static readonly JiraSettingTypeCustomFieldName HelpDeskTicketCustomFieldName = new(2, "HelpDeskTicketCustomFieldName");
        public static readonly JiraSettingTypeCustomFieldName SnagItCustomFieldName = new(3, "SnagItCustomFieldName");
        public static readonly JiraSettingTypeCustomFieldName DescriptionCustomFieldName = new(4, "DescriptionCustomFieldName");

        public JiraSettingTypeCustomFieldName(int value, string name)
        {
            Value = value;
            Name = name;
        }

        public int Value { get; set; }
        public string Name { get; set; }

        public static readonly JiraSettingTypeCustomFieldName[] All =
        {
            OperatingSystemCustomFieldName,
            HelpDeskTicketCustomFieldName,
            SnagItCustomFieldName,
            DescriptionCustomFieldName
        };

        public static List<string> GetAllLowerNames()
        {
            List<string> allNames = new();

            foreach (JiraSettingTypeCustomFieldName api in All)
            {
                allNames.Add(api.Name.ToLower());
            }

            return allNames;
        }

        public static JiraSettingTypeCustomFieldName Find(int value)
        {
            return All.FirstOrDefault(x => x.Value == value);
        }

        public static JiraSettingTypeCustomFieldName FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
