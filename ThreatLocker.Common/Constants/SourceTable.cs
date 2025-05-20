using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class SourceTable
    {
        public static readonly SourceTable ActionLog = new SourceTable(1, "ActionLog");
        public static readonly SourceTable DenyActionLog = new SourceTable(2, "DenyActionLog");
        public static readonly SourceTable BaselineActionLog = new SourceTable(3, "BaselineActionLog");
        public static readonly SourceTable EventLogActionLog = new SourceTable(4, "EventLogActionLog");

        public SourceTable(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly SourceTable[] All =
        {
            ActionLog,
            DenyActionLog,
            BaselineActionLog,
            EventLogActionLog
        };

        public static SourceTable Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }
    }
}
