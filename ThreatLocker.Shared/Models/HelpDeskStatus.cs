namespace ThreatLocker.Shared.Models
{
    public class HelpDeskStatus
    {
        public int HelpDeskStatusId { get; set; }

        public string DisplayName { get; set; }

        public int DisplayOrder { get; set; }

        public int? HelpDeskStatusCategoryId { get; set; }

        public bool IsActive { get; set; }

        public bool IsReadOnly { get; set; }

    }
}
