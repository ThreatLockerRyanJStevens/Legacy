using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class AlertStatusType
    {
        public static readonly AlertStatusType All = new AlertStatusType(0, "All");
        public static readonly AlertStatusType Active = new AlertStatusType(1, "Active");
        public static readonly AlertStatusType Cleared = new AlertStatusType(2, "Cleared");
        public static readonly AlertStatusType Lockdown = new AlertStatusType(3, "Lockdown");
        public static readonly AlertStatusType Isolate = new AlertStatusType(4, "Isolate");

        // Alert is hidden in Detect Alert Center but shows in sidebar
        public static readonly AlertStatusType Remediated = new AlertStatusType(5, "Remediated");

        public static readonly AlertStatusType Resolved = new AlertStatusType(6, "Resolved");
        public static readonly AlertStatusType Snoozed = new AlertStatusType(7, "Snoozed");

        public static readonly AlertStatusType LockoutAccount = new AlertStatusType(8, "Lockout Account");

        public AlertStatusType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly AlertStatusType[] AllTypes =
        {
            All,
            Active,
            Cleared,
            Lockdown, 
            Isolate,
            Remediated,
            Resolved,
            Snoozed,
            LockoutAccount,
        };

        public static readonly int[] ThreatTypes =
        {
            Active.Id,
            Cleared.Id
        };

        public static readonly int[] RemediationTypes =
        {
            Lockdown.Id,
            Isolate.Id,
            LockoutAccount.Id,
        };

        // Status for alert list in Computer sidebar
        public static readonly int[] ObjectListTypes =
        {
            Active.Id,
            Remediated.Id,
            Snoozed.Id
        };

        public static readonly int[] InvalidUpdateTypes =
        {
            Active.Id,
            Lockdown.Id,
            Isolate.Id,
            Snoozed.Id
        };

        public static AlertStatusType Find(int id)
        {
            return AllTypes.FirstOrDefault(x => x.Id == id);
        }

        public static AlertStatusType FindByName(string name)
        {
            return AllTypes.FirstOrDefault(x => x.Name.ToLower() == name);
        }
    }
}
