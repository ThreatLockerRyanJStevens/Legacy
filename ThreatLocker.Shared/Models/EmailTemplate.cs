using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Models
{
    public class EmailTemplate
    {
        public Guid EmailTemplateId { get; set; }

        public Guid UserId { get; set; }

        public string Template { get; set; }

        public DateTime CreatedOn { get; set; }

        public string TemplateName { get; set; }

        public bool Global { get; set; }

        public string EmailSubject { get; set; }

    }
}
