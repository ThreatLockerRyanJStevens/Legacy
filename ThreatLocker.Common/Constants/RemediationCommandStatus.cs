using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class RemediationCommandStatus
    {
        public static readonly RemediationCommandStatus Pending = new RemediationCommandStatus(0, "Pending", "Command received from portal");
        public static readonly RemediationCommandStatus Sent = new RemediationCommandStatus(1, "Sent", "Command sent to client/computer");
        public static readonly RemediationCommandStatus Completed = new RemediationCommandStatus(2, "Completed", "Command ran successfully on client machine");
        public static readonly RemediationCommandStatus Failed = new RemediationCommandStatus(3, "Failed", "Command failed to run on client machine");

        public RemediationCommandStatus(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public int Id { get; }
        public string Name { get; }
        public string Description { get; }

        public static readonly RemediationCommandStatus[] All =
        {
            Pending,
            Sent,
            Completed,
            Failed
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
