using System.Collections.Generic;
using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class TrayPushNotificationType
    {
        public static readonly TrayPushNotificationType Approval = new TrayPushNotificationType(1, "execute", new List<string>() { "execute" });
        public static readonly TrayPushNotificationType ElevationApproval = new TrayPushNotificationType(2, "elevate", new List<string>() { "elevate" });
        public static readonly TrayPushNotificationType Custom = new TrayPushNotificationType(3, "custom");
        public static readonly TrayPushNotificationType VDIRunNow = new TrayPushNotificationType(4, "vdirunnow");
        public static readonly TrayPushNotificationType StorageApproval = new TrayPushNotificationType(5, "storage", new List<string>() { "read", "write", "move", "delete" });
        public static readonly TrayPushNotificationType DisableOpsAlerts = new TrayPushNotificationType(6, "disableopsalerts");
        public static readonly TrayPushNotificationType WebControlApproval = new TrayPushNotificationType(7, "network", new List<string>() { "network" });

        public TrayPushNotificationType(int id, string name, List<string> actionTypes = null)
        {
            Id = id;
            Name = name;
            ActionTypes = actionTypes != null ? actionTypes : new List<string>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> ActionTypes { get; set; } = new List<string>();

        public static readonly TrayPushNotificationType[] All =
        {
            Approval,
            ElevationApproval,
            Custom,
            VDIRunNow,
            StorageApproval,
            DisableOpsAlerts,
            WebControlApproval
        };

        public static readonly TrayPushNotificationType[] Approvals =
        {
            Approval,
            ElevationApproval,
            StorageApproval,
            WebControlApproval
        };

        public static TrayPushNotificationType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static TrayPushNotificationType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }

        public static TrayPushNotificationType FindByActionType(string actionType)
        {
            return Approvals.FirstOrDefault(x => x.ActionTypes.Contains(actionType));
        }
    }
}
