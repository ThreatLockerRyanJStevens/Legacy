using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class FieldLabelType
    {
        public static readonly FieldLabelType Ticket = new FieldLabelType(1, "Ticket");
        public static readonly FieldLabelType Status = new FieldLabelType(2, "Status");
        public static readonly FieldLabelType Comment = new FieldLabelType(3, "Comment");
        public static readonly FieldLabelType TicketOwner = new FieldLabelType(4, "Ticket Owner");
        public static readonly FieldLabelType Category = new FieldLabelType(5, "Category");
        public static readonly FieldLabelType Organization = new FieldLabelType(6, "Ticket Organization");
        public static readonly FieldLabelType PrimaryContact = new FieldLabelType(7, "Primary Contact");
        public static readonly FieldLabelType Summary = new FieldLabelType(8, "Summary");
        public static readonly FieldLabelType Description = new FieldLabelType(9, "Description");
        public static readonly FieldLabelType CCContacts = new FieldLabelType(10, "CC contacts");
        public static readonly FieldLabelType MergedTicket = new FieldLabelType(11, "Merged Ticket");
        public static readonly FieldLabelType DepreciatedTicketId = new FieldLabelType(12, "Depreciated Ticket Id");
        public static readonly FieldLabelType Transcript = new FieldLabelType(13, "Transcript");
        public static readonly FieldLabelType RatingStars = new FieldLabelType(14, "Rating Stars");
        public static readonly FieldLabelType RatingComments = new FieldLabelType(15, "Rating Comments");
        public static readonly FieldLabelType Rating = new FieldLabelType(16, "Rating");
        public static readonly FieldLabelType StatusOverdue = new FieldLabelType(17, "Status Overdue");
        public static readonly FieldLabelType Assignees = new FieldLabelType(18, "Assignees");
        public static readonly FieldLabelType Chat = new FieldLabelType(19, "Chat");
        public static readonly FieldLabelType File = new FieldLabelType(20, "File");

        public FieldLabelType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly FieldLabelType[] All =
        {
            Ticket,
            Status,
            Comment,
            TicketOwner,
            Category,
            Organization,
            PrimaryContact,
            Summary,
            Description,
            CCContacts,
            MergedTicket,
            DepreciatedTicketId,
            Transcript,
            RatingStars,
            RatingComments,
            Rating,
            StatusOverdue,
            Assignees,
            Chat,
            File
        };

        public static FieldLabelType Find(int value)
        {
            return All.FirstOrDefault(x => x.Id == value);
        }

        public static FieldLabelType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
