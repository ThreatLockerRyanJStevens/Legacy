﻿using System;

namespace ThreatLockerCommon.ViewModels
{
    [Serializable]
    public class TicketUser
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string UserId { get; set; }
        public string CellPhone { get; set; }
        public string EmailAddress { get; set; }
    }
}
