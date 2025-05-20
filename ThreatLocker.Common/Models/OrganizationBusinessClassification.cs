using System;

namespace ThreatLockerCommon.Models
{
    [Serializable]
    public class OrganizationBusinessClassification
    {
        public Guid OrganizationId { get; set; }
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public int CategoryTypeId { get; set; }
        public string CategoryTypeName { get; set; }
    }
}