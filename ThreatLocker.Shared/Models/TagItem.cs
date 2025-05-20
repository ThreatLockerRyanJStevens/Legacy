using System;

namespace ThreatLocker.Shared.Models
{
    public class TagItem
    {
        public Guid TagId { get; set; }

        public string Value { get; set; }

        public int StatusId { get; set; }

        public int TransactionTypeId { get; set; }

        public long RelatedTagItemId { get; set; }

        public long TagItemId { get; set; }

        public string Prefix { get; set; }

        public Guid OrganizationId { get; set; }

    }
}
