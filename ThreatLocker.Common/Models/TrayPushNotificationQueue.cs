using System;

namespace ThreatLockerCommon.Models
{
    public class TrayPushNotificationQueue
    {
        public Guid NotificationBatchId { get; set; } = Guid.Empty;
        public DateTime CreateDate { get; set; }
        public int AppliesToType { get; set; }
        public Guid AppliesToId { get; set; }
        public Guid ComputerId { get; set; }
        public string Username { get; set; }
        public string Notification { get; set; }
        public int NotificationType { get; set; }
        public string Payload { get; set; }
        public DateTime Expiry { get; set; }
        public int FrequencyInHours { get; set; }
        public DateTime? LastSentToTray { get; set; }
        public DateTime? LastTrayReceived { get; set; }
    }
}
