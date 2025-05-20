using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class FailedAction
    {
        public string ActionType { get; set; }
        public string FailedSource { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorStackTrace { get; set; }
        public string Details { get; set; }
    }

    public class FailedComputerTransaction
    {
        public Guid OrganizationId { get; set; }
        public Guid ParentId { get; set; }
        public Guid ComputerId { get; set; }
        public string SalesEmail { get; set; }
        public string SalesEngineerEmail { get; set; }
        public string TransactionType { get; set; }
        public bool Secured = false;

    }
}
