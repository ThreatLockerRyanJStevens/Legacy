using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class RemediatorMFAStatusType
    {
        public static readonly RemediatorMFAStatusType Pending = new RemediatorMFAStatusType(0, "Pending");
        public static readonly RemediatorMFAStatusType Accepted = new RemediatorMFAStatusType(1, "Accepted");
        public static readonly RemediatorMFAStatusType Declined = new RemediatorMFAStatusType(2, "Declined");

        public RemediatorMFAStatusType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly RemediatorMFAStatusType[] All =
        {
            Pending,
            Accepted,
            Declined,
        };

        public static readonly RemediatorMFAStatusType[] Completed =
        {
            Accepted,
            Declined,
        };

        public static RemediatorMFAStatusType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static RemediatorMFAStatusType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }

        public static bool IsCompleted(int status)
        {
            return Completed.Any(a => a.Id == status);
        }
    }
}
