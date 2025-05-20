using System;

namespace ThreatLockerCommon.Models
{
    public class Menu
    {
        public Guid MenuId { get; set; }
        public string NavigationURL { get; set; }
        public string Name { get; set; }
        public string ImgUrlWhite { get; set; }
        public string ImgUrlBlack { get; set; }
        public int OrderBy { get; set; }
        public Guid? ParentId { get; set; }
        public bool IsMasterOnly { get; set; }
        public bool IsActive { get; set; }
        public bool IsBeta { get; set; }
        public string Attributes { get; set; }
        public string ResxKey { get; set; }
        public bool HasRestrictions { get; set; }
    }
}
