using System.Linq;

namespace ThreatLocker.Shared.Constants.PatchManagement
{
    public class PatchTransactionType
    {
        public static readonly PatchTransactionType Pending = new(1, "pending", "Pending");
        public static readonly PatchTransactionType Completed = new(2, "completed", "Completed");
        public static readonly PatchTransactionType Canceled = new(3, "canceled", "Canceled");
        public static readonly PatchTransactionType Skipped = new(4, "skipped", "Skipped");
        
        public PatchTransactionType(int id, string value, string name)
        {
            Id = id;
            Value = value;
            Name = name;
        }

        public int Id { get; set; }
        public string Value { get; set; }
        public string Name { get; set; }

        public static readonly PatchTransactionType[] All =
        {
            Pending,
            Skipped,
            Canceled,
            Completed,
        };

        public static bool IsValid(int id)
        {
            return All.Any(p => p.Id == id);
        }
    }
}
