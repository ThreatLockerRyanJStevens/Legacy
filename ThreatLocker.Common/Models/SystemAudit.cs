using System;

namespace ThreatLockerCommon.Models
{
    public class SystemAuditItem
    {
        public Guid OrganizationId { get; set; }
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Action { get; set; } //Read, Modify, Delete, Create, Logon, Logoff
        public string IPAddress { get; set; }
        public string EffectiveAction { get; set; } //Permitted | Denied
        public SystemAuditDetails Details { get; set; }
        public bool MasterViewOnly { get; set; }
    }

    public class SystemAuditDetails
    {
        public string Page { get; set; } // Nice formatting e.g. securitycenter.aspx = Security Center
        public string Function { get; set; } //View Page
        public Guid ObjectId { get; set; } // This is the OrgId, or ComputerId, or PolicyId, etc that they are adding
        public string Details { get; set; }
    }

    public static class SystemAuditItemEffectiveAction
    {
        public static string Permittted // Prevent crashing of existing code
        {
            get
            {
                return "Permitted";
            }
        }

        public static string Permitted
        {
            get
            {
                return "Permitted";
            }
        }

        public static string Denied
        {
            get
            {
                return "Denied";
            }
        }
    }

    public static class SystemAuditItemAction
    {
        public static string Read
        {
            get
            {
                return "Read";
            }
        }

        public static string Delete
        {
            get
            {
                return "Delete";
            }
        }

        public static string Create
        {
            get
            {
                return "Create";
            }
        }

        public static string Logon
        {
            get
            {
                return "Logon";
            }
        }

        public static string Logoff
        {
            get
            {
                return "Logoff";
            }
        }

        public static string Modify
        {
            get
            {
                return "Modify";
            }
        }
    }
}
