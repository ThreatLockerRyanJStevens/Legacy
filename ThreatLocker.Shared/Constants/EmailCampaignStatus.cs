using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class EmailCampaignStatus
    {
        public static readonly EmailCampaignStatus Composing = new EmailCampaignStatus(0, "Emails have not been sent yet");
        public static readonly EmailCampaignStatus ReadyToSend = new EmailCampaignStatus(1, "Emails are ready to be sent out to users");
        public static readonly EmailCampaignStatus Successful = new EmailCampaignStatus(2, "Emails have been sent to all users");
        public static readonly EmailCampaignStatus PartiallySuccessful = new EmailCampaignStatus(3, "Not all users have received their emails");
        public static readonly EmailCampaignStatus Delayed = new EmailCampaignStatus(4, "Scheduled emails have been delayed");
        public static readonly EmailCampaignStatus Abandonded = new EmailCampaignStatus(5, "Campaign has been abandonded");
        public static readonly EmailCampaignStatus Reopened = new EmailCampaignStatus(6, "Campagin has been reopened");
        public static readonly EmailCampaignStatus Failed = new EmailCampaignStatus(7, "Something went wrong during the processing of the campaign");

        public EmailCampaignStatus(int id, string name)
        {
            Id = id;
            Description = name;
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public static readonly EmailCampaignStatus[] All =
       {
            Composing,
            ReadyToSend,
            Successful,
            PartiallySuccessful,
            Delayed,
            Abandonded,
            Reopened,
            Failed
       };

        public static EmailCampaignStatus Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static EmailCampaignStatus FindByDescription(string name)
        {
            return All.FirstOrDefault(x => x.Description == name);
        }
    }
}
