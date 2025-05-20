using System.Collections.Generic;

namespace ThreatLockerCommon.Models
{
    public class Configuration
    {
        public int ConfigurationType { get; set; }
        public List<ConfigurationSetting> ConfigurationSettings { get; set; } = new List<ConfigurationSetting>();
    }

    public class ConfigurationSetting
    {
        public int ConfigurationFieldGroupId { get; set; }
        public ConfigurationField[] Fields { get; set; }
    }

    public class ConfigurationField
    {
        public int ConfigurationFieldId { get; set; }
        public string Value { get; set; }
    }
}
