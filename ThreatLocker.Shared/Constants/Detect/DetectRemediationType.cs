using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class DetectRemediationType
    {
        public static readonly DetectRemediationType All = new DetectRemediationType(0, "All");
        public static readonly DetectRemediationType IsolateComputer = new DetectRemediationType(1, "Isolate Computer");
        public static readonly DetectRemediationType LockdownComputer = new DetectRemediationType(2, "Lockdown Computer");
        public static readonly DetectRemediationType LockoutAccount = new DetectRemediationType(3, "Lockout Account");

        public DetectRemediationType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly DetectRemediationType[] AllTypes =
        {
            IsolateComputer,
            LockdownComputer,
            LockoutAccount
        };

        public static readonly int[] EndpointTypes =
        {
            IsolateComputer.Id,
            LockdownComputer.Id,
        };

        public static readonly int[] CloudTypes =
        {
            LockoutAccount.Id,
        };

        public static DetectRemediationType Find(int id)
        {
            return AllTypes.FirstOrDefault(x => x.Id == id);
        }

        public static DetectRemediationType FindByName(string name)
        {
            return AllTypes.FirstOrDefault(x => x.Name.ToLower() == name);
        }
    }
}
