using System;

namespace ThreatLocker.Shared.Models
{
    public class AzureGroup
    {
        public Guid Id { get; set; }
        public string DisplayName { get; set; }

        public AzureGroup() { }

        public AzureGroup(Guid id, string displayName)
        {
            Id = id;
            DisplayName = displayName;
        }
    }
}
