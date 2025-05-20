using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class ApprovalRequestModel
    {
        public Guid ApprovalRequestId { get; set; }
        public Guid OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public DateTime DateTime { get; set; }
        public string Path { get; set; }
        public string Username { get; set; }
        public string Hostname { get; set; }
        public int StatusId { get; set; }
        public string ComputerId { get; set; }
        public string JSON { get; set; }
        public string SerialNumber { get; set; }
        public string ActionType { get; set; }
        public string DeviceType { get; set; }
        public string ApprovedBy { get; set; }
        public string Notes { get; set; }
        public string Comments { get; set; }
        public string TicketId { get; set; }
        public string Requestor { get; set; }
        public string RequestorReason { get; set; }
        public Guid? MultiLevelApprovalRequestId { get; set; }
        public int MultiLevelApprovalStatusId { get; set; }
        public Guid? TempPolicyId { get; set; }
        public Guid? PolicyId { get; set; }
        public Guid? TempApplicationId { get; set; }
        public Guid? ApplicationId { get; set; }
        public int InitialApprovalTierLevel { get; set; }
        public int ApprovalCount { get; set; }
        public int ApprovalNumber { get; set; }
        public int PendingTierLevel { get; set; }
        public bool HasPendingApprovalRequest { get; set; }
        public int VirtualItemCount { get; set; }
        public string PortalURL { get; set; }
        public string ApiURL { get; set; }
        public bool IsAssigned { get; set; }
        public string AssigneeUserId { get; set; }
        public string AssigneeUsername { get; set; }
    }
}
