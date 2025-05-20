using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class ActionType
    {
        public static readonly ActionType None = new ActionType(0, "none");
        public static readonly ActionType Baseline = new ActionType(1, "baseline");
        public static readonly ActionType Configuration = new ActionType(2, "configuration");
        public static readonly ActionType Delete = new ActionType(3, "delete");
        public static readonly ActionType Elevate = new ActionType(4, "elevate");
        public static readonly ActionType Execute = new ActionType(5, "execute");
        public static readonly ActionType Install = new ActionType(6, "install");
        public static readonly ActionType Move = new ActionType(7, "move");
        public static readonly ActionType Network = new ActionType(8, "network");
        public static readonly ActionType NewProcess = new ActionType(9, "newprocess");
        public static readonly ActionType PowerShell = new ActionType(10, "PowerShell");
        public static readonly ActionType Read = new ActionType(11, "read");
        public static readonly ActionType Registry = new ActionType(12, "registry");
        public static readonly ActionType Uninstall = new ActionType(13, "uninstall");
        public static readonly ActionType Write = new ActionType(14, "write");
        public static readonly ActionType OSEventLog = new ActionType(15, "OSEventLog");

        public ActionType(int id, string value)
        {
            Id = id;
            Value = value;
        }

        public int Id { get; set; }
        public string Value { get; set; }

        public static readonly ActionType[] All =
        {
            None,
            Baseline,
            Configuration,
            Delete,
            Elevate,
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

        /// <summary>
        /// Returns true if ActionType is a file write.
        /// </summary>
        /// <param name="actionType"></param>
        /// <returns>True if ActionType is Write, Delete or Move.</returns>
        public static bool IsWrite(string actionType)
        {
            return actionType == ActionType.Write.Value
                || actionType == ActionType.Delete.Value
                || actionType == ActionType.Move.Value;
        }

        public static ActionType FindById(int id)
        {
            return All.FirstOrDefault(x => x.Id == id) ?? None;
        }

        public static ActionType FindByValue(string value)
        {
            return All.FirstOrDefault(x => x.Value == value) ?? None;
        }
    }
}
