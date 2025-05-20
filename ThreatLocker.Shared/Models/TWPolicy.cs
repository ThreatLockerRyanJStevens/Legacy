using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Models
{
    public class TWPolicy
    {
        public Guid TWPolicyId { get; set; }

        public Guid? OrganizationId { get; set; }

        public string PolicyName { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int? OrderBy { get; set; }

        public Guid? AppliesTo { get; set; }

        public int TWConfigurationId { get; set; }

        public short? State { get; set; }

        public DateTime? LastUpdatedDate { get; set; }

        public string LastUpdatedBy { get; set; }

        public string Requestor { get; set; }

        public string Comments { get; set; }

        public string TicketInfo { get; set; }

        public bool IsEnabled { get; set; }

        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public bool IsDeleted { get; set; }

    }

}
