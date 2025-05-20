using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class TemplateEmailTicketType
    {
        public static readonly TemplateEmailTicketType Sender = new TemplateEmailTicketType(1, "ThreatLocker Cyber Heroes <noreply@threatlocker.com>");

        public TemplateEmailTicketType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly TemplateEmailTicketType[] All =
        {
            Sender
        };

        public static TemplateEmailTicketType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }
    }
}
