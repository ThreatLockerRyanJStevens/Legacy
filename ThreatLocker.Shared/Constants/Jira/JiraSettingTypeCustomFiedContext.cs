using System.Collections.Generic;
using System.Linq;

namespace ThreatLocker.Shared.Constants.Jira
{
    public class JiraSettingTypeCustomFiedContext
    {
        public static readonly JiraSettingTypeCustomFiedContext OperatingSystemCustomFieldContextId = new(1, "OperatingSystemCustomFieldContextId");

        public JiraSettingTypeCustomFiedContext(int value, string name)
        {
            Value = value;
            Name = name;
        }

        public int Value { get; set; }
        public string Name { get; set; }

        public static readonly JiraSettingTypeCustomFiedContext[] All =
        {
            OperatingSystemCustomFieldContextId
        };

        public static List<string> GetAllLowerNames()
        {
            List<string> allNames = new();

            foreach (JiraSettingTypeCustomFiedContext api in All)
            {
                allNames.Add(api.Name.ToLower());
            }

            return allNames;
        }

        public static JiraSettingTypeCustomFiedContext Find(int value)
        {
            return All.FirstOrDefault(x => x.Value == value);
        }

        public static JiraSettingTypeCustomFiedContext FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
