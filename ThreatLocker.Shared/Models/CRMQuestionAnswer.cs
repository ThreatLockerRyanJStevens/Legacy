using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Models
{
    public class CRMQuestionAnswer
    {
        public int CRMQuestionAnswerId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public DateTime DateTime { get; set; }
        public Guid OrganizationId { get; set; }
        public Guid? AnsweredBy { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public bool IsRemoved { get; set; }
    }
}
