using System.ComponentModel;

namespace ThreatLockerCommon.Enums
{
    public enum RulesEngineLearningModule
    {
        [Description("Application Name")]
        ApplicationName = 1,
        [Description("Application File")]
        ApplicationFile = 2,
        [Description("Application File Full Path")]
        ApplicationFileFullPath = 3
    }
}
