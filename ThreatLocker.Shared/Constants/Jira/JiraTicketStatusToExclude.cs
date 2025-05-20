using System.Collections.Generic;
using System.Linq;

namespace ThreatLocker.Shared.Constants.Jira
{
    public class JiraTicketStatusToExclude
    {
        public static readonly JiraTicketStatusToExclude Done = new(1, "Done");
        public static readonly JiraTicketStatusToExclude Discarded = new(2, "Discarded");
        public static readonly JiraTicketStatusToExclude PendingDeployLive = new(3, "Pending Deploy Live");

        public JiraTicketStatusToExclude(int value, string name)
        {
            Value = value;
            Name = name;
        }

        public int Value { get; set; }
        public string Name { get; set; }

        public static readonly JiraTicketStatusToExclude[] All =
        {
            Done,
            Discarded,
            PendingDeployLive
        };

        public static List<string> GetAllLowerNames()
        {
            List<string> allNames = new();

            foreach (JiraTicketStatusToExclude api in All)
            {
                allNames.Add(api.Name.ToLower());
            }

            return allNames;
        }

        public static JiraTicketStatusToExclude Find(int value)
        {
            return All.FirstOrDefault(x => x.Value == value);
        }

        public static JiraTicketStatusToExclude FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
