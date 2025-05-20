using System;

namespace ThreatLocker.Shared.Models
{
    public class ComputerTransaction
    {
        public DateTime DateTime { get; set; }

        public Guid OrganizationId { get; set; }

        public Guid ParentId { get; set; }

        public Guid ComputerId { get; set; }

        public string SalesEmail { get; set; }

        public string SalesEngineerEmail { get; set; }

        public string TransactionType { get; set; }

    }

}
