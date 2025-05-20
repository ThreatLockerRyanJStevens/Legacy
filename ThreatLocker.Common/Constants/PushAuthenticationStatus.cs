using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class PushAuthenticationStatus
    {
        public static readonly PushAuthenticationStatus RequiresSending = new PushAuthenticationStatus(0, "Requires Sending");
        public static readonly PushAuthenticationStatus Approved = new PushAuthenticationStatus(1, "Approved");
        public static readonly PushAuthenticationStatus Denied = new PushAuthenticationStatus(2, "Denied");
        public static readonly PushAuthenticationStatus Timeout = new PushAuthenticationStatus(3, "Timeout");
        public static readonly PushAuthenticationStatus SendFailed = new PushAuthenticationStatus(4, "Send Failed");
        public static readonly PushAuthenticationStatus SendSuccess = new PushAuthenticationStatus(5, "Send Success");

        public PushAuthenticationStatus(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        
        public static readonly PushAuthenticationStatus[] All =
        {
            RequiresSending,
            Approved,
            Denied,
            Timeout,
            SendFailed,
            SendSuccess
        };

        //Optional Find method
        public static PushAuthenticationStatus Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        //Optional Find method
        public static PushAuthenticationStatus FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
