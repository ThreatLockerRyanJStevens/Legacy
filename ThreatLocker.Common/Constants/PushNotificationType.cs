using System;
using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class PushNotificationType
    {
        public static readonly PushNotificationType General = new PushNotificationType(0, "General");
        public static readonly PushNotificationType ApprovalRequest = new PushNotificationType(1, "Approval Request");


        public PushNotificationType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly PushNotificationType[] All =
        {
            General,
            ApprovalRequest
        };

        public static PushNotificationType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static PushNotificationType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
