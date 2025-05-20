using System;

namespace ThreatLockerCommon.Constants
{
    public class DataCenter
    {
        public static readonly DataCenter A = new DataCenter(new Guid("A42FD2EB-3749-4F37-8688-C9236C79A876"), "A");
        public static readonly DataCenter B = new DataCenter(new Guid("628CCE3B-0E0F-4272-AF86-58FBF1FA5764"), "B");
        public static readonly DataCenter C = new DataCenter(new Guid("D49093E8-7458-4223-A982-47BC4FD610E2"), "C");
        public static readonly DataCenter D = new DataCenter(new Guid("DA41A773-06F2-48C0-8E68-A5C6C5D05A5B"), "D");
        public static readonly DataCenter E = new DataCenter(new Guid("3C2BE9E7-59CF-4FBD-BD7B-2AA73D102415"), "E");
        public static readonly DataCenter F = new DataCenter(new Guid("F58CAF82-83B4-41E0-BDC0-DE0911EAA34C"), "F");
        public static readonly DataCenter G = new DataCenter(new Guid("D3708B0D-9705-484A-AF4B-6E59D903472A"), "G");

        public DataCenter(Guid dataCenterId, string instanceName)
        {
            DataCenterId = dataCenterId;
            InstanceName = instanceName;
        }

        public Guid DataCenterId { get; set; }
        public string InstanceName { get; set; }

        public static readonly DataCenter[] All =
        {
            A, B, C, D, E, F, G
        };

        public static readonly DataCenter TrialInstance = G;
    }
}
