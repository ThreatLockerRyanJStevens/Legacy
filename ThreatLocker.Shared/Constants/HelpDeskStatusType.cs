using System;
using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class HelpDeskStatusType
    {
        public static readonly HelpDeskStatusType Open = new HelpDeskStatusType(1, "Open", 1);
        public static readonly HelpDeskStatusType InProgress = new HelpDeskStatusType(2, "In Progress", 6);
        public static readonly HelpDeskStatusType Resolved = new HelpDeskStatusType(3, "Resolved", 4);
        public static readonly HelpDeskStatusType CustomerInputRequired = new HelpDeskStatusType(4, "Customer Input Required", 2);
        public static readonly HelpDeskStatusType Scheduled = new HelpDeskStatusType(5, "Scheduled", 6);
        public static readonly HelpDeskStatusType UpdatedByCustomer = new HelpDeskStatusType(6, "Updated By Customer", 3);
        public static readonly HelpDeskStatusType ConfirmedResolvedByCustomer = new HelpDeskStatusType(7, "Confirmed Resolved By Customer", 5);
        public static readonly HelpDeskStatusType NotResolved = new HelpDeskStatusType(8, "Not Resolved", 3);
        public static readonly HelpDeskStatusType ResolvedWhitoutEmail = new HelpDeskStatusType(9, "Resolved Whitout Email", 5);
        public static readonly HelpDeskStatusType ClosedNotResponse = new HelpDeskStatusType(10, "Closed not Response", 5);
        public static readonly HelpDeskStatusType EscaledToDevelopment = new HelpDeskStatusType(12, "Escaled to Development", 6);
        public static readonly HelpDeskStatusType IssueWithReplication = new HelpDeskStatusType(13, "Issue with Replication", 6);
        public static readonly HelpDeskStatusType DeployedToBetaPortal = new HelpDeskStatusType(14, "Deployed to beta Portal", 6);
        public static readonly HelpDeskStatusType BackendInvestication = new HelpDeskStatusType(15, "Backend Investigation", 6);
        public static readonly HelpDeskStatusType BackEndInvestigationComplete = new HelpDeskStatusType(16, "Backend Investigation Complete", 6);
        public static readonly HelpDeskStatusType PurchaseRequest = new HelpDeskStatusType(17, "Purchase Request", 6);
        public static readonly HelpDeskStatusType Duplicated = new HelpDeskStatusType(18, "Duplicated", 5);
        public static readonly HelpDeskStatusType FeatureRequest = new HelpDeskStatusType(19, "Feature Request Raised", 4);

        public HelpDeskStatusType(int value, string name, int category)
        {
            Value = value;
            Name = name;
            Category = category;
        }

        public int Value { get; set; }
        public string Name { get; set; }
        public int Category { get; set; }

       public static readonly HelpDeskStatusType[] All =
       {
            Open,
            InProgress,
            Resolved,
            CustomerInputRequired,
            Scheduled,
            UpdatedByCustomer,
            ConfirmedResolvedByCustomer,
            NotResolved,
            ResolvedWhitoutEmail,
            ClosedNotResponse,
            EscaledToDevelopment,
            IssueWithReplication,
            DeployedToBetaPortal,
            Duplicated
        };

        public static readonly int[] ReadOnlyToCyberHero =
        {
            ConfirmedResolvedByCustomer.Value
        };

        public static HelpDeskStatusType Find(int value)
        {
            return All.FirstOrDefault(x => x.Value == value);
        }

        public static HelpDeskStatusType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
        public static HelpDeskStatusType FindByCategory(int category)
        {
            return All.FirstOrDefault(x => x.Category == category);
        }
    }
}
