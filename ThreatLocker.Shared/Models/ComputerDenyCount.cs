using System;

namespace ThreatLocker.Shared.Models
{
    public class ComputerDenyCount
    {
        public Guid ComputerId { get; set; }

        public int? OneDay { get; set; }

        public int? ThreeDays { get; set; }

        public int? FourDays { get; set; }

        public int? SevenDays { get; set; }

    }

}
