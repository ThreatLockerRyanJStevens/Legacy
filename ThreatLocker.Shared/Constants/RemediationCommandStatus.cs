using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class RemediationCommandStatus
    {
        public static readonly RemediationCommandStatus Pending = new RemediationCommandStatus(0, "Pending");
        public static readonly RemediationCommandStatus Sent = new RemediationCommandStatus(1, "Sent");
        public static readonly RemediationCommandStatus Completed = new RemediationCommandStatus(2, "Completed");
        public static readonly RemediationCommandStatus Failed = new RemediationCommandStatus(3, "Failed");

        public RemediationCommandStatus(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly RemediationCommandStatus[] All =
        {
            Pending,
            Sent,
            Completed,
            Failed,
        };

        public static readonly RemediationCommandStatus[] Done =
        {
            Completed,
            Failed,
        };

        public static RemediationCommandStatus Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static RemediationCommandStatus FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
