using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class DriverApp
    {
        public MakeAndModelApplication Model { get; set; }
        public MakeAndModelApplication Make { get; set; }
        public MakeAndModelApplication Vendor { get; set; }
        public DriverApplication Driver { get; set; }
    }
    public class MakeAndModelApplication
    {
        public string Name { get; set; }
        public Guid ApplicationId { get; set; }
    }

    public class DriverApplication
    {
        public string URL { get; set; }
        public Guid ApplicationId { get; set; }
    }
}
