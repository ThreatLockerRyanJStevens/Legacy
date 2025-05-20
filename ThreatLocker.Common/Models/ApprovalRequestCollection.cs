using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class ApprovalRequestCollection
    {
        public List<ApprovalRequestModel> ApprovalRequests { get; set; } = new List<ApprovalRequestModel>();
        public int VirtualItemCount { get; set; }
    }
}
