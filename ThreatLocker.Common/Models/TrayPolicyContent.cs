using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class TrayPolicyContent
    {
        public Guid TrayContentId { get; set; }
        public Guid OrganizationId { get; set; }
        public Guid PolicyId { get; set; }
        public string PopupMessage { get; set; }
        public string PopupRequestButtonText { get; set; }
        public string PopupHideButtonText { get; set; }
        public string RequestTitleText { get; set; }
        public string RequestMessageText { get; set; }
        public string RequestSendButtonText { get; set; }
        public string RequestLoginButtonText { get; set; }
        public string RequestCancelButtonText { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public bool Active { get; set; } = true;
        public string RequestEmailMessage { get; set; }
        public string RequestEmailAddress { get; set; }
        public bool DefaultFile { get; set; } = true;
        public string AttachFileText { get; set; }
        public string RedirectUrl { get; set; }
        public int AppliesToType { get; set; }
    }
}
