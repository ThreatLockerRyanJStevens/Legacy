using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class CommissionStatusType
    {
        public static readonly CommissionStatusType Requested = new (1, "Requested");
        public static readonly CommissionStatusType Approved = new (2, "Approved");
        public static readonly CommissionStatusType Rejected = new(3, "Rejected");
        public static readonly CommissionStatusType RejectedWithPrejudice = new(4, "Rejected With Prejudice");
        public static readonly CommissionStatusType Authorized = new (5, "Authorized");

        public CommissionStatusType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; }
        public string Name { get; }

        public static implicit operator int(CommissionStatusType type) => type.Id;

        public static readonly CommissionStatusType[] All =
        {
            Requested,
            Approved,
            Authorized,
            Rejected,
            RejectedWithPrejudice
        };

        public static CommissionStatusType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static CommissionStatusType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
