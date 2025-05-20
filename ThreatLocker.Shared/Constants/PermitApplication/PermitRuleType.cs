using System.Linq;

namespace ThreatLocker.Shared.Constants.PermitApplication
{
    public class PermitRuleType
    {
        /// <summary>
        /// Temporarily disable protection and learn installed files with Installation Mode
        /// </summary>
        public static readonly PermitRuleType InstallationMode = new PermitRuleType(1, "Use Installation Mode");
        /// <summary>
        /// Temporarily disable protection and learn all installed files with Learning Mode
        /// </summary>
        public static readonly PermitRuleType LearningMode = new PermitRuleType(2, "Use Learning Mode");
        /// <summary>
        /// Temporarily disable protection, do not learn any files and log activity with Monitor Only Mode
        /// </summary>
        public static readonly PermitRuleType MonitorOnlyMode = new PermitRuleType(3, "Use Monitor Only Mode");

        public PermitRuleType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly PermitRuleType[] All =
        {
            InstallationMode,
            LearningMode,
            MonitorOnlyMode
        };

        public static PermitRuleType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static PermitRuleType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
