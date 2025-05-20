namespace ThreatLocker.Shared.Constants
{
    public class ConfigurationStatusType
    {
        public static readonly ConfigurationStatusType Enabled = new ConfigurationStatusType(1, "Enabled");
        public static readonly ConfigurationStatusType DisabledByUser = new ConfigurationStatusType(2, "Disabled By User");
        public static readonly ConfigurationStatusType DisabledBySystem = new ConfigurationStatusType(3, "Disabled By System");

        public ConfigurationStatusType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
