using System;
using System.ComponentModel;

namespace ThreatLocker.Shared.Models
{
    public class AddToApplicationQueue
    {
        public long ActionLogId { get; set; }

        [DefaultValue("")]
        public Guid ComputerId { get; set; }

        [DefaultValue("")]
        public Guid OrganizationId { get; set; }

        [DefaultValue("")]
        public Guid TargetApplicationId { get; set; }

        [DefaultValue(1)]
        public int SourceTableId { get; set; }

        [DefaultValue("")]
        public Guid EActionLogId { get; set; }
    }
}
