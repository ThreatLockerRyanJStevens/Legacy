using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ThreatLockerCommon.Models
{
    public class CRMDocument
    {
        public Guid crmDocumentId { get; set; }
        public string name { get; set; }
        public DateTime dateTime { get; set; }
        public string digitalSignatureId { get; set; }
        public string emailAddress { get; set; }
        public string signedStatus { get; set; }
        public string lastViewed { get; set; }
    }
}
