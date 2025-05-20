using System.Linq;

namespace ThreatLocker.Shared.Constants.User
{
    public class PushAuthenticationStatusType
    {
        public static readonly PushAuthenticationStatusType RequiresSending = new PushAuthenticationStatusType(0, "Requires Sending");
        public static readonly PushAuthenticationStatusType Approved = new PushAuthenticationStatusType(1, "Approved");
        public static readonly PushAuthenticationStatusType Denied = new PushAuthenticationStatusType(2, "Denied");
        public static readonly PushAuthenticationStatusType Timeout = new PushAuthenticationStatusType(3, "Timeout");
        public static readonly PushAuthenticationStatusType SendFailed = new PushAuthenticationStatusType(4, "Send Failed");
        public static readonly PushAuthenticationStatusType SendSuccess = new PushAuthenticationStatusType(5, "Send Success");

        public PushAuthenticationStatusType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly PushAuthenticationStatusType[] All =
        {
            RequiresSending,
            Approved,
            Denied,
            Timeout,
            SendFailed,
            SendSuccess
        };

        public static readonly int[] ApprovedDeniedTimeout =
        {
            Approved.Id,
            Denied.Id,
            Timeout.Id
        };

        public static PushAuthenticationStatusType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static PushAuthenticationStatusType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name.ToLower() == name);
        }
    }
}
