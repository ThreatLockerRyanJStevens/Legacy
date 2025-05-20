using System;

namespace ThreatLocker.Shared.Models
{
    [Serializable]
    public class ThreatLockerDataCenter
    {
        public DataCenter ObjDataCenter { get; set; }
        public DataCenterEnvironment ObjDataCenterEnvironment { get; set; }
    }
}
