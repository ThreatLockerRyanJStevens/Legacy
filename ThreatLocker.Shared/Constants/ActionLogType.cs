using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Constants
{
    public class ActionLogType
    {
        public static readonly ActionLogType Permit = new ActionLogType(1, "Permit");
        public static readonly ActionLogType Deny = new ActionLogType(2, "Deny");
        public static readonly ActionLogType DenyOptionToRequest = new ActionLogType(3, "Deny (Option to Request)");
        public static readonly ActionLogType InstallMode = new ActionLogType(4, "Install Mode");
        public static readonly ActionLogType MissingCoreFiles = new ActionLogType(5, "Missing Core Files");
        public static readonly ActionLogType Ringfenced = new ActionLogType(6, "Ringfenced");
        public static readonly ActionLogType AnyDeny = new ActionLogType(99, "Any Deny");

        public ActionLogType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly ActionLogType[] All =
        {
            Permit,
            Deny,
            DenyOptionToRequest,
            InstallMode,
            MissingCoreFiles,
            Ringfenced,
            AnyDeny
        };

        public static readonly ActionLogType[] UnifiedAuditAdvancedSearchActions =
        {
            Permit,
            AnyDeny,
            Deny,
            DenyOptionToRequest,
            Ringfenced
        };

        public static ActionLogType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static ActionLogType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
