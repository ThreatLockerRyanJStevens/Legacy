using System.Collections.Generic;

namespace ThreatLockerCommon.Models
{
    public class SendGridEmail
    {
        public List<SendGridEmailPersonalization> personalizations { get; set; }
        public SendGridEmailAddress from { get; set; }
        public List<SendGridEmailContent> content { get; set; }

        public SendGridTrackingSetting tracking_settings { get; set; }

        public SendGridOpenTracking open_tracking { get; set; }
        public List<SendGridAttachment> attachments { get; set; }
    }
    public class SendGridEmailPersonalization
    {
        public List<SendGridEmailAddress> to { get; set; }

        public List<SendGridEmailAddress> cc { get; set; }

        public List<SendGridEmailAddress> bcc { get; set; }

        public string subject { get; set; }
    }

    public class SendGridEmailAddress
    {
        public string email { get; set; }
        public string name { get; set; }
    }

    public class SendGridEmailContent
    {
        public string type { get; set; }
        public string value { get; set; }
    }
    public class SendGridTrackingSetting
    {
        public SendGridClickTracking click_tracking { get; set; }
    }
    public class SendGridClickTracking
    {
        public bool enable { get; set; }
        public bool enable_text { get; set; }
    }
    public class SendGridOpenTracking
    {
        public bool enable { get; set; }
    }

    public class SendGridAttachment
    {
        public string content { get; set; }
        public string filename { get; set; }
        public string type { get; set; }
        public string disposition { get; set; }
        public string content_id { get; set; }
    }
}