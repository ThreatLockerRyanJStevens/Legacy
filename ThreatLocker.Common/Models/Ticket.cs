using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreatLockerCommon.ViewModels;

namespace ThreatLockerCommon.Models
{
   public class Ticket
    {    // THIS CLASS IS USED TO RETURN 2 OBJECTS BASED ON SELECETED PROERPTIES, THE TICKET OBJECT AND THE TICKET INSTANCE OBJECT 
        public long TicketId { get; set; }
        public string TicketNumber { get; set; }
        public string OrganizationId { get; set; }
        public string Organization { get; set; }
        public string RequesterName { get; set; }
        public string RequesterPhone { get; set; }
        public string RequesterEmail { get; set; }
        public int CategoryId { get; set; }    //Last or current
        public int StatusId { get; set; }      //Last or current  
        public int MethodId { get; set; }    //Last or current
        public string AssignedId { get; set; }    //Last or current
        public string CreatedBy { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime LastUpdated { get; set; }
        public int ClientRating { get; set; }
        public string ClientRatingMsg { get; set; }
        public string AdminMsg { get; set; }
        public string TicketSubject { get; set; }
        public string Description { get; set; }
        public string ManagerFirstName { get; set; }
        public string ManagerLastName { get; set; }
        public string ManagerId { get; set; }
        public string TicketAllAssignees { get; set; }
        public string CC { get; set; }
        //The Following are instance specific properties
        public long InstanceID { get; set; }
        public string InstanceAssigned { get; set; }   
        public string InstanceManager { get; set; }    
        public string UpdatedBy { get; set; }   
        public string AssignedName { get; set; }
        public string UpdatedByName { get; set; }
        public string SystemNote { get; set; }
        public  bool IsInternal { get; set; }
        public string TicketNote { get; set; }
        public string AttachmentPath { get; set; }
        public List<TicketAttachment> TicketAttachments { get; set; }
        public string InstanceMethod { get; set; }
        public string  InstanceStatus { get; set; }
        public DateTime InstanceDate { get; set; }
        public string InstanceUri { get; set; }

        public string TicketError { get; set; }

        public DateTime TimeTicketOpened { get; set; }

        public DateTime TimeResolvedOwner { get; set; }

        public DateTime TimeResolvedCustomer { get; set; }
        public int VirtualCount { get; set; }
        public string RequesterId { get; set; }

        // Can be deleted after helpdesk goes live.
        public string TicketNo { get; set; }
        public string AssginedId { get; set; }
        public string TicketAllAsignees { get; set; }
        public string AssginedName { get; set; }
        public string AttchmentPath { get; set; }
    }

    public class TicketPaging
    {
        public List<Ticket> Tickets { get; set; } = new List<Ticket>();
        public int VirtualCount { get; set; }
    }
    public class TicketSearchCriteria
    {
        public string TicketNumber { get; set; }
        public int? CategoryID { get; set; }
        public int? StatusID { get; set; }
        public string AssignedUserID { get; set; }
        public int? MethodID { get; set; }
        public string SearchText { get; set; }
        public string Organization { get; set; }
        public string TicketSubject { get; set; }
        public string OrganizationId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public bool? IncludeResolved { get; set; }
        public DataTable OrganizationIds { get; set; }
    }

    public class SupportAssigned
    {
        public int AssgndID = 0;
        public string AssgndName = string.Empty;
        public string UserName = string.Empty;
        public string CellPhone = string.Empty;
        public string PhoneNo = string.Empty;
        public string FirstName = string.Empty;
        public string LastName = string.Empty;
        public string Email = string.Empty;
        public int PermissionID = 0;
        public string  UserID = string.Empty;
    }

    public class TicketParameters
    {
        public List<TicketUser> AllAgents = new List<TicketUser>();
        public Dictionary<string, string> AllCategory = new Dictionary<string, string>();
        public Dictionary<string, string> AllMethod = new Dictionary<string, string>();
        public Dictionary<string, string> AllStatus = new Dictionary<string, string>();
        public Dictionary<string, string> AllOwners = new Dictionary<string, string>();
    }

    public class TicketRequester
    {    
        public string UserName = string.Empty;
        public string UserId = string.Empty;
        public string CellPhone = string.Empty;
        public string PhoneNumber = string.Empty;
        public string FirstName = string.Empty;
        public string LastName = string.Empty;
        public string OrganizationId = string.Empty;
        public string OrganizationName = string.Empty;
    }

    public class MainHelpCenterParameters
    {
        public string TicketNumber = string.Empty;
        public string CategoryID = string.Empty;
        public string StatusID = string.Empty;
        public string AssignedID = string.Empty;
        public string MethodID = string.Empty;
        public string RequesterName = string.Empty;
        public string Organization = string.Empty;
        public string StartDate = string.Empty;
        public string EndDate = string.Empty;
    }

    public class TicketAudit
    {
        public Guid SystemAuditId { get; set; }

        public DateTime DateTime { get; set; }

        public string Username { get; set; }

        public string Action { get; set; }

        public string IPAddress { get; set; }

        public string Page { get; set; }

        public string Function { get; set; }

        public string Details { get; set; }

        public string EffectiveAction { get; set; }

        public string GeoLocationCountry { get; set; }
    }

    public class TicketAuditPaging
    {
        public List<TicketAudit> TicketAudits { get; set; } = new List<TicketAudit>();
        public int VirtualCount { get; set; }
    }
}
