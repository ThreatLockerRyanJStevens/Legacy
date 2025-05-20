using System.Linq;

namespace ThreatLocker.Shared.Constants.Jira
{
    public class JiraStaticRouteVariables
    {
        public static readonly JiraStaticRouteVariables FieldNumber = new(1, "{fieldNumber}");
        public static readonly JiraStaticRouteVariables ContextId = new(2, "{contextId}");
        public static readonly JiraStaticRouteVariables ProjectId = new(3, "{projectId}");
        public static readonly JiraStaticRouteVariables TicketNumber = new(3, "{ticketNumber}");

        public JiraStaticRouteVariables(int value, string name)
        {
            Value = value;
            Name = name;
        }

        public int Value { get; set; }
        public string Name { get; set; }

        public static readonly JiraStaticRouteVariables[] All =
        {
            FieldNumber,
            ContextId,
            ProjectId,
            TicketNumber
        };

        public static JiraStaticRouteVariables Find(int value)
        {
            return All.FirstOrDefault(x => x.Value == value);
        }

        public static JiraStaticRouteVariables FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());
        }
    }
}
