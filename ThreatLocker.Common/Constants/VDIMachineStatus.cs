using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Constants
{
    public class VDIMachineStatus
    {
        public static readonly VDIMachineStatus Inactive = new VDIMachineStatus("Inactive", 0);
        public static readonly VDIMachineStatus Ready = new VDIMachineStatus("Ready", 1);
        public static readonly VDIMachineStatus InUse = new VDIMachineStatus("In Use", 2);
        public static readonly VDIMachineStatus RecyclingAndMerging = new VDIMachineStatus("Recycling and Merging", 3);
        public static readonly VDIMachineStatus RecyclingAndDiscarding = new VDIMachineStatus("Recycling and Discarding", 4);

        // Delete this after build goes live
        public static readonly VDIMachineStatus Recycling = new VDIMachineStatus("Recycling", 5);

        public string Name { get; set; }
        public int Id { get; set; }

        public VDIMachineStatus(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public static readonly List<VDIMachineStatus> All = new List<VDIMachineStatus>
        {
            Ready,
            InUse,
            RecyclingAndMerging,
            RecyclingAndDiscarding,
            Recycling
        };
    }
}
