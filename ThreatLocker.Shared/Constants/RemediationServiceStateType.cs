using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class RemediationServiceStateType
    {
        public static readonly RemediationServiceStateType Start = new RemediationServiceStateType(1, "Start");
        public static readonly RemediationServiceStateType Stop = new RemediationServiceStateType(2, "Stop");
        //public static readonly RemediationServiceState Restart = new RemediationServiceState(3, "Restart");

        public RemediationServiceStateType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly RemediationServiceStateType[] All =
        {
            Start,
            Stop,
        };

        public static RemediationServiceStateType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static RemediationServiceStateType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
