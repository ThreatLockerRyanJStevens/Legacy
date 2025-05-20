using System;

namespace ThreatLockerCommon.Models
{
    //Created to be used on serialization of json string
    public class PolicySchedule
    {
        public DayOfWeek Day { get; set; }
        public int StartMinute { get; set; } //minutes from start of day on local PC
        public int Duration { get; set; } // minutes until end time
    }
}
