using System;

namespace ThreatLockerCommon.Models
{
    public class Setting
    {
        public int SettingId { get; set; }
        public int SettingTypeId { get; set; }
        public Guid ObjectId { get; set; }
        public string Value { get; set; }
        public int ObjectTypeId { get; set; }
    }
}
