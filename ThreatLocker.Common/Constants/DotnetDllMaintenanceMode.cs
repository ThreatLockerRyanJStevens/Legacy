using System;
using System.Collections.Generic;
using ThreatLockerCommon.Models;

namespace ThreatLockerCommon.Constants
{
    public class DotnetDllMaintenanceModes
    {
        private static MaintenanceMode _learnComputer =
            new MaintenanceMode
            {
                MaintenanceId = new Guid("4BF2E778-1BE4-4759-A687-E6A3A87DEA72"),
                Type = "learning",
                StartDate = DateTime.UtcNow.AddYears(-1),
                EndDate = DateTime.UtcNow.AddYears(1),
                Users = new List<string>(),
                Application = "",
                AppliesToType = MaintenanceModeAppliesToType.Computer.Id
            };

        private static MaintenanceMode _learnGroup =
            new MaintenanceMode
            {
                MaintenanceId = new Guid("8F263637-F4FE-4846-BE0E-57335BB553EE"),
                Type = "learning",
                StartDate = DateTime.UtcNow.AddYears(-1),
                EndDate = DateTime.UtcNow.AddYears(1),
                Users = new List<string>(),
                Application = "",
                AppliesToType = MaintenanceModeAppliesToType.ComputerGroup.Id
            };

        private static MaintenanceMode _learnSystem =
            new MaintenanceMode
            {
                MaintenanceId = new Guid("68B79254-DB87-4D5E-B7FB-BB24292F1254"),
                Type = "learning",
                StartDate = DateTime.UtcNow.AddYears(-1),
                EndDate = DateTime.UtcNow.AddYears(1),
                Users = new List<string>(),
                Application = "",
                AppliesToType = MaintenanceModeAppliesToType.System.Id
            };

        private static MaintenanceMode _monitorOnly =
            new MaintenanceMode
            {
                MaintenanceId = new Guid("331EACE4-6474-4430-95F5-1F3FBE6F06DA"),
                Type = "monitoronly",
                StartDate = DateTime.UtcNow.AddYears(-1),
                EndDate = DateTime.UtcNow.AddYears(1),
                Users = new List<string>(),
                Application = ""
            };

        public static MaintenanceMode LearnComputer
        {
            get { return _learnComputer; }
        }

        public static MaintenanceMode LearnGroup
        {
            get { return _learnGroup; }
        }

        public static MaintenanceMode LearnSystem
        {
            get { return _learnSystem; }
        }

        public static MaintenanceMode MonitorOnly
        {
            get { return _monitorOnly; }
        }
    }
}
