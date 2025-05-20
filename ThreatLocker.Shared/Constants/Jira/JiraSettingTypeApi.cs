using System.Collections.Generic;
using System.Linq;

namespace ThreatLocker.Shared.Constants.Jira
{
    public class JiraSettingTypeApi
    {
        public static readonly JiraSettingTypeApi BaseApiUrl = new(1, "BaseApiUrl");
        public static readonly JiraSettingTypeApi ApiUsername = new(2, "ApiUsername");
        public static readonly JiraSettingTypeApi ApiToken = new(3, "ApiToken");

        public JiraSettingTypeApi(int value, string name)
        {
            Value = value;
            Name = name;
        }

        public int Value { get; set; }
        public string Name { get; set; }

        public static readonly JiraSettingTypeApi[] All =
        {
            BaseApiUrl,
            ApiUsername,
            ApiToken
        };

        public static List<string> GetAllLowerNames()
        {
            List<string> allNames = new();

            foreach (JiraSettingTypeApi api in All)
            {
                allNames.Add(api.Name.ToLower());
            }

            return allNames;
        }

        public static JiraSettingTypeApi Find(int value)
        {
            return All.FirstOrDefault(x => x.Value == value);
        }

        public static JiraSettingTypeApi FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
