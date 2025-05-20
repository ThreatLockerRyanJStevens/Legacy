using RulesEngine.EngineModule_Classes;
using System.ComponentModel;

namespace RulesEngine
{
    public enum ModuleType
    {
        [Description("None")]
        None = 0,
        [Description("Application Name Learning")]
        ApplicationNameLearning = 1,
        [Description("Application File Learning")]
        ApplicationFileLearning = 2,
        [Description("Application File FullPath Learning")]
        ApplicationFileFullPathLearning = 3
    }

    public class EngineModule
    {
        public EngineModule(ModuleType type)
        {
            Type = type;
        }

        public EngineModule(ModuleType type, int osType)
        {
            Type = type;
            OSType = osType;
        }

        public ActionLogItem RuleObject { get; set; }
        public ModuleType Type { get; set; } = ModuleType.None;
        public int OSType { get; set; } = OperatingSystemType.Windows.Id;

        public override string ToString()
        {
            return $"Module: {(int)Type}; OSType: {OperatingSystemType.Find(OSType).Name};";
        }
    }
}
