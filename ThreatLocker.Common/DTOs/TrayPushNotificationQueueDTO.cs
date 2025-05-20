using System;

namespace ThreatLockerCommon.DTOs
{
    public class TrayPushNotificationQueueServiceDTO
    {
        public long TrayPushNotificationQueueId { get; set; }
        public string Username { get; set; }
        public string Notification { get; set; }
        public int NotificationType { get; set; }
        public string Payload { get; set; }
        public DateTime Expiry { get; set; }
        public int FrequencyInHours { get; set; }
        public DateTime? LastTrayReceived { get; set; }
    }
}
