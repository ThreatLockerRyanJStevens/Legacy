using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class ActionType
    {
        public static readonly ActionType None = new ActionType(0, "", "None");
        public static readonly ActionType Baseline = new ActionType(1, "baseline", "Baseline");
        public static readonly ActionType Configuration = new ActionType(2, "configuration", "Configuration");
        public static readonly ActionType Delete = new ActionType(3, "delete", "Delete");
        public static readonly ActionType Elevation = new ActionType(4, "elevate", "Elevation");
        public static readonly ActionType Execute = new ActionType(5, "execute", "Execute");
        public static readonly ActionType Install = new ActionType(6, "install", "Install");
        public static readonly ActionType Move = new ActionType(7, "move", "Move");
        public static readonly ActionType Network = new ActionType(8, "network", "Network");
        public static readonly ActionType NewProcess = new ActionType(9, "newprocess", "New Process");
        public static readonly ActionType PowerShell = new ActionType(10, "powershell", "PowerShell");
        public static readonly ActionType Read = new ActionType(11, "read", "Read");
        public static readonly ActionType Registry = new ActionType(12, "registry", "Registry");
        public static readonly ActionType Uninstall = new ActionType(13, "uninstall", "Uninstall");
        public static readonly ActionType Write = new ActionType(14, "write", "Write");
        public static readonly ActionType OSEventLog = new ActionType(15, "oseventlog", "OS Event Log");

        public ActionType(int id, string value, string name)
        {
            Id = id;
            Value = value;
            Name = name;
        }

        public int Id { get; set; }
        public string Value { get; set; }
        public string Name { get; set; }

        public static readonly ActionType[] All =
        {
            None,
            Baseline,
            Configuration,
            Delete,
            Elevation,
            Execute,
            Install,
            Move,
            Network,
            NewProcess,
            PowerShell,
            Read,
            Registry,
            Uninstall,
            Write,
            OSEventLog
        };

        public static readonly string[] ApplicationRequestTypes =
        {
            Execute.Value,
            Elevation.Value,
            Baseline.Value,
            Install.Value,
            NewProcess.Value
        };

        public static readonly string[] StorageRequestTypes =
        {
            Read.Value,
            Write.Value,
            Move.Value,
            Delete.Value
        };

        public static readonly string[] NetworkRequestTypes =
        {
            Network.Value
        };

        public static readonly int[] StorageRequestIds =
        {
            Read.Id,
            Write.Id,
            Move.Id,
            Delete.Id
        };

        public static ActionType Find(string value)
        {
            return All.FirstOrDefault(x => x.Value == value);
        }

        public static ActionType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }

        public static ActionType FindById(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }
    }
}
