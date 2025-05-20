using System;
using System.Collections.Generic;

namespace ThreatLockerCommon.Models
{
    public class ADGroup
    {
        public string Name { get; set; }
        public string GroupDN { get; set; }
        public string Transaction { get; set; }
    }
}