using System;
using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class UserPermission
    {
        public static readonly UserPermission ReadOnly = new UserPermission("0A85D8FF-FCF5-4363-A707-0A9F08FB7EDF", 
            "Read Only");

        public static readonly UserPermission ActiveComputerDeleteOverride = new UserPermission("36BA1B2F-0AD7-4B40-89E5-14F1893A7A4D", 
            "Active Computer Delete Override");

        public static readonly UserPermission AllowApplicationMerge = new UserPermission("F9BBB446-9615-4ABF-A308-EC7ADC6D51C9", 
            "Allow Application Merge");

        public static readonly UserPermission AllowCheckCore = new UserPermission("A82BCC5B-9AB4-4FB3-B842-CD0F7CDE58EC", 
            "Allow Check Core");

        public static readonly UserPermission AllowEditQuotes = new UserPermission("985FB0F8-EB5E-4042-B020-9DD75EBC92FB", 
            "Allow Edit Quotes");

        public static readonly UserPermission AllowEmailTemplateCreationAndEditing = new UserPermission("3D4EE2DA-1498-4531-B5CE-1BC6AF8F0D1A", 
            "Allow Email Template Creation And Editing");

        public static readonly UserPermission AllowGlobalEmailTemplate = new UserPermission("09812480-73AB-4CCC-8CEF-8AA3EFBAF4BD", 
            "Allow Global Email Template");

        public static readonly UserPermission AllowBulkEmailSending = new UserPermission("6DBD7F11-F4D4-42F3-B8DF-B3C1B633F40D", 
            "Allow Bulk Email Sending");

        public static readonly UserPermission AllowQuoteApprovalOnBehalfOfOrganization = new UserPermission("22A40AF5-44E1-4CD0-B4CF-F22ED059B0EA", 
            "Allow Quote Approval On Behalf Of Organization");

        public static readonly UserPermission AllowReassigningInCRM = new UserPermission("2EC463A8-C8D3-488E-B411-0CF648CE432C", 
            "Allow Reassigning In CRM");

        public static readonly UserPermission AllowRedownloadCore = new UserPermission("7B790F94-DDF3-41CF-B17B-C34B4029D5FF", 
            "Allow Redownload Core");

        public static readonly UserPermission AllowViewCheckinHistory = new UserPermission("1886C6B1-1A8C-4D44-A3BC-964AE3AC8D99", 
            "Allow View Checkin History");

        public static readonly UserPermission AllowViewingPostSignedQuote = new UserPermission("DA04EF6E-2741-4D4F-9C40-291834296493", 
            "Allow Editing Post Signed Quote");

        public static readonly UserPermission AllowEditQuoteAdditionalTerms = new UserPermission("93DB7A30-5569-4EE3-A4D7-986198003C3F", 
            "Allow Edit Quote Additional Terms");

        public static readonly UserPermission ApproveForEntireOrganization = new UserPermission("1EAF014F-7F9F-4B60-9DC1-54E98FAB50F7", 
            "Approve for Entire Organization");

        public static readonly UserPermission ApproveForGroup = new UserPermission("A955E157-FD8F-46DE-80E0-AD069201D510", 
            "Approve for Group");

        public static readonly UserPermission ApproveForSingleComputer = new UserPermission("940DE5BE-F8E2-4DB7-AA4E-CB083AB2599F", 
            "Approve for Single Computer");

        public static readonly UserPermission ApproveForSingleComputerApplicationOnly = new UserPermission("764B45A4-A25A-475D-8ECC-51A48B284B4D", 
            "Approve for Single Computer (Application Only)");

        public static readonly UserPermission AppTeam = new UserPermission("118BD1EF-CED2-4554-AD15-B71B1790AEB4", 
            "App Team");

        public static readonly UserPermission ChangePermission = new UserPermission("93359E43-3725-4A4B-AA28-CB2447958A70", 
            "Change Permission");

        public static readonly UserPermission ChangeUserTierLevel = new UserPermission("DCA53D2A-9B06-430C-A20D-D27A9F08CB9E", 
            "Change User Tier Level");

        public static readonly UserPermission CyberHero = new UserPermission("7919DAB5-3B3F-48D3-8319-4554620C0D02", 
            "Cyber Hero");

        public static readonly UserPermission CyberHeroManagementProcessing = new UserPermission("B8980D3B-A9CB-4378-AEE5-E3C3C8F88BDD", 
            "Cyber Hero Approvals Processing");

        public static readonly UserPermission DeleteInvoices = new UserPermission("155DB7AD-FB98-4B4F-AA6B-5B0DA70AAD74", 
            "CRM Delete Invoices");

        public static readonly UserPermission EditAdministrators = new UserPermission("33EBE311-7B41-48A7-9385-12A3B58F2CFC", 
            "Edit Administrators");

        public static readonly UserPermission EditApplicationCheckUpdatePoints = new UserPermission("9B5FABC1-E715-47B7-8019-3A78CC5B5812", 
            "Edit Application Check/Update Points");

        public static readonly UserPermission EditApplicationControlApplications = new UserPermission("C72E7E3D-70D3-4C7D-9F53-1AAB744A25BA", 
            "Edit Application Control Applications");

        public static readonly UserPermission EditApplicationControlPolicies = new UserPermission("CB1E5487-6FDC-4C1D-8418-E491F86E6215", 
            "Edit Application Control Policies");

        public static readonly UserPermission EditBilling = new UserPermission("44B745AA-6805-4904-8897-8B484228FB8C", 
            "Edit Billing");

        public static readonly UserPermission EditComputerGroups = new UserPermission("53A3BDCA-A616-4D5C-AB08-5BE2BBC79389", 
            "Edit Computer Groups");

        public static readonly UserPermission EditComputers = new UserPermission("1AFE37CA-9432-467B-B1F0-788E9B01489C", 
            "Edit Computers");

        public static readonly UserPermission EditIntegrations = new UserPermission("7DB31A8D-F70F-4F29-BFF3-97B6B0F2D90D", 
            "Edit Integrations");

        public static readonly UserPermission EditOrganizations = new UserPermission("5E4B402A-5111-4526-AD8A-8A38E4F74EA3", 
            "Edit Organizations");

        public static readonly UserPermission EditStorageControlPolicies = new UserPermission("63AB13DD-07AB-4E22-926D-50F27350B4B2", 
            "Edit Storage Control Policies");

        public static readonly UserPermission EditStorageControlStorageDevices = new UserPermission("CBCB99F9-611A-4941-8E8B-1F8F6A4EB7E2", 
            "Edit Storage Control Storage Devices");

        public static readonly UserPermission ElevationAdministrator = new UserPermission("29AB9B6D-0AB8-4164-95B7-E60C7738EED7", 
            "Elevation Administrator");

        public static readonly UserPermission HelpDeskManagement = new UserPermission("9E50F730-A101-4D42-8D1C-C58C4385F004", 
            "Help Desk Management");

        public static readonly UserPermission Invoicing = new UserPermission("CE907234-A4AF-47C6-8B40-38A0E2ECE35F", 
            "Invoicing");

        public static readonly UserPermission AllowIssueRefund = new UserPermission("0B84B38A-4EB5-48D6-B68F-D03DFA78A09B", 
            "Allow Issue Refund");

        public static readonly UserPermission LeadershipTeam = new UserPermission("21BD7EF4-98EA-46CA-AE72-97F003D655DD", 
            "Leadership Team");

        public static readonly UserPermission ManageBuiltInApplications = new UserPermission("F915CC37-D6E7-4775-B2C0-A3FA3EFCF70C", 
            "Manage Built-In Applications");

        public static readonly UserPermission ManageEngineRules = new UserPermission("4254778B-023C-4BEE-998F-CBA022A06DB6",
            "Manage Engine Rules");

        public static readonly UserPermission ManageHiddenApplications = new UserPermission("EE07DC1B-39DB-40C1-9131-229C63DF87AF", 
            "Manage Hidden Applications");

        public static readonly UserPermission ProductManagement = new UserPermission("44F8BDBA-6CA0-411D-B823-ED2094CEDA3A", 
            "Product Management");

        public static readonly UserPermission SalesEngineer = new UserPermission("70E24616-F568-4C34-8806-BBE9E5C2EBCE", 
            "Sales Engineer");

        public static readonly UserPermission SalesManager = new UserPermission("29F9AC79-2F7E-4824-A125-C30C2D08814D", 
            "Sales Manager");

        public static readonly UserPermission SalesPerson = new UserPermission("E50B59B9-CE2E-4207-A804-6C07D0BA800B", 
            "Sales Person");

        public static readonly UserPermission SuperAdmin = new UserPermission("6434D492-E5A4-40B6-AD2C-4B62A56CCAFA", 
            "Super Admin");

        public static readonly UserPermission SuperAdminChild = new UserPermission("5FBC0B48-7366-421D-9337-02B619BA7243", 
            "Super Admin - Child");

        public static readonly UserPermission SuperAdminLoggedInOrganizationOnly = new UserPermission("A2EA998D-DEAE-4C32-9AE0-7628DFE4576C",
            "Super Admin - Logged-In Organization Only");

        public static readonly UserPermission ViewAdministrators = new UserPermission("4FCFBECE-F330-45A6-8E35-E22C8C6D6BC0", 
            "View Administrators");

        public static readonly UserPermission ViewApplicationCheckUpdatePoints = new UserPermission("FA56E63C-9BFD-42B9-A9CE-9B3A376CA9E5", 
            "View Application Check/Update Points");

        public static readonly UserPermission ViewApprovals = new UserPermission("8CC77E90-B062-4AC9-9A35-0CBFDDBFA7AF", 
            "View Approvals");

        public static readonly UserPermission ViewBilling = new UserPermission("EB920389-F79D-44CD-92CB-F8E418F6CDD0", 
            "View Billing");

        public static readonly UserPermission ViewDashboard = new UserPermission("FDFB5462-5635-4EED-AF1B-42D2E22ADB11", 
            "View Dashboard");

        public static readonly UserPermission ViewDeploymentCenter = new UserPermission("B03CF944-5C22-48AC-8BCF-1D1A5894CE44", 
            "View Deployment Center");

        public static readonly UserPermission ViewHiddenPermissions = new UserPermission("7EC5A730-FA0F-4969-92CD-45782A605242", 
            "View Hidden Permissions");

        public static readonly UserPermission ViewOrganizations = new UserPermission("417B1A08-BC44-4A02-898B-2DA454D13308", 
            "View Organizations");

        public static readonly UserPermission ViewReports = new UserPermission("1A8BE4F4-F49A-4938-9496-03E1CE433335", 
            "View Reports");

        public static readonly UserPermission ViewSystemAudit = new UserPermission("C7F49A1A-6127-4FB1-86E4-9EF527F2DC0B", 
            "View System Audit");

        public static readonly UserPermission ViewUnifiedAudit = new UserPermission("CA5EC20C-278E-4F87-8E19-4B1C8092CC6E", 
            "View Unified Audit");

        public static readonly UserPermission EditLogonSettings = new UserPermission("79A15EC5-2256-484C-AFE8-2A97555A7592", 
            "Edit Logon Settings");

        public static readonly UserPermission EditMultiLevelApprovals = new UserPermission("FA73FFAE-26AD-44B8-95BE-D162A1C81991", 
            "Edit Multi-Level Approvals");

        public static readonly UserPermission ViewMultiLevelApprovals = new UserPermission("8A1278D2-6586-4F21-A0D6-4A6CEAB1C20E", 
            "View Multi-Level Approvals");

        public static readonly UserPermission CustomerBillingAccess = new UserPermission("8D4FDFD2-513F-4A49-A2B3-9F0B0EF62454", 
            "Customer Billing Access");

        public static readonly UserPermission CRMAllowSendingFromOtherUsers = new UserPermission("BFDE646B-A573-45BB-A0ED-F409C89C88DA", 
            "CRM Allow Sending From Other Users");

        public static readonly UserPermission CRMDeletePayment = new UserPermission("83C77059-A0A8-45A0-A561-1A864AE7CD8C", 
            "CRM Delete Payments");

        public static readonly UserPermission CRMTakeStripePayment = new UserPermission("9B1CE527-1BBD-405D-9A34-51B654E6C995", 
            "CRM Take Stripe Payments");

        public static readonly UserPermission CRMExceedAmountDue = new UserPermission("2C2B4CEA-0FAA-4391-A983-52CE2EA02048", 
            "CRM Exceed Amount Due");

        public static readonly UserPermission CRMSendInvoice = new UserPermission("10C870CE-0F56-439F-BC9D-93977F009181", 
            "CRM Send Invoice");

        public static readonly UserPermission HelpDeskUnassignOwner = new UserPermission("FE426A5E-E3A4-487A-BDEB-93E1A8C7404B", 
            "Help Desk Unassign Owner");

        public static readonly UserPermission PromoteToGroup = new UserPermission("FF782DA7-1E19-49E6-8156-1F0C6F0C668A", 
            "Promote To Group");

        public static readonly UserPermission PromoteToOrganization = new UserPermission("3C2DD077-60F2-42B4-9F89-8AFCA873E95E", 
            "Promote To Entire Organization");

        public static readonly UserPermission RoleAdministrator = new UserPermission("3BB6F2A7-4193-45D3-870A-815DB85120C0", 
            "Role Administrator");

        public static readonly UserPermission ExtendTrialPast60Days = new UserPermission("36E6F128-BA0C-4A5D-856D-0E4E5A4B7FAD",
            "Extend Trial Past 60 Days");

        public static readonly UserPermission AssignRoles = new UserPermission("E24C9D1E-CBBD-480B-9640-0034ECF042CB",
            "Assign Roles");

        public static readonly UserPermission ViewOverrideCodes = new UserPermission("60962720-5AA2-4F75-B5B4-BF2E3845716B",
            "View Override Codes");

        public static readonly UserPermission AccountManager = new UserPermission("788FB31E-528A-4AC7-873D-96AEDB411BF4",
            "Account Manager");

        public static readonly UserPermission HelpDeskResolveFromPage = new UserPermission("614EAD04-92E9-4487-82D4-FDFF04B9D181",
            "Help Desk Resolve From Page");

        public static readonly UserPermission EditNetworkAccessControlPolicies = new UserPermission("F09D9258-D3A0-4015-BEEA-1BDC023534CC",
            "Edit Network Access Control Policies");

        public static readonly UserPermission EditNACAuthorizationHosts = new UserPermission("73579C3E-9B55-4711-A48D-9607E67121C1",
            "Edit NAC Authorization Hosts");

        public static readonly UserPermission CRMExportContacts = new UserPermission("61B79D48-959A-4ABA-AF6E-F1258232A2DC",
            "CRM Export Contacts");

        public static readonly UserPermission CRMEditQuoteTerm = new UserPermission("AC5F4128-936C-4B49-AB80-6C2EE6FF2DA3",
            "CRM Edit Quote Term");

        public static readonly UserPermission CRMEditReplaceQuotes = new UserPermission("7C05BEF3-3114-409B-8E1D-CCF8D481A5AA",
            "CRM Edit Replace Quotes");

        public static readonly UserPermission CRMEditOnetimeQuotes = new UserPermission("DBD598EF-8150-44DC-93A5-C881C8E4EDEC",
            "CRM Edit One-time Quotes");

        public static readonly UserPermission CRMEditAppendNFRQuotes = new UserPermission("B050C651-36F3-42A5-B32A-9BEECE97309E",
            "CRM Edit Append NFR Quotes");

        public static readonly UserPermission CRMEditQuoteThreatLockerOrganization = new UserPermission("37D662D0-9BBF-4369-B5FC-84491EE818BE",
            "CRM Edit Quote ThreatLocker Organization");

        public static readonly UserPermission ManageTags = new UserPermission("A3D1E873-75E8-4FB3-AF43-2DFEB03165CF",
            "Manage Tags");

        public static readonly UserPermission ReportRevenue = new UserPermission("ABCC08A8-C8B2-4CA3-9978-349FFCA180C1",
            "Revenue");

        public static readonly UserPermission ReportStaffFigures = new UserPermission("F94CCE19-EE24-42F9-9C58-523EBE3992EF",
            "Staff Figures");

        public static readonly UserPermission ReportGenerateAPIKeys = new UserPermission("54BFF606-94DF-4D35-A12B-60CE4DC76FEE",
            "Generate API Keys");

        public static readonly UserPermission ReportMarkInvoiceAsUnpaid = new UserPermission("991AE94D-C841-44CD-BFB7-27AA2A221F2D",
            "Mark Invoice as Unpaid");

        public static readonly UserPermission ReportNewThreatLockerVersion = new UserPermission("2263EEA2-EFC8-4E28-B0E8-FA0F2213D1CE",
            "New ThreatLocker Version");

        public static readonly UserPermission ReportSyncMasterPermissions = new UserPermission("0CE9E818-34BE-4C0B-85B5-AA03AA742D2C",
            "Sync Master Permissions");

        public static readonly UserPermission ReportUpdateTLVersionAlphaToBeta = new UserPermission("7356065B-4FB4-44B2-B400-03672E6E2B0E",
            "Update TL Version: Alpha to Beta");

        public static readonly UserPermission ReportUpdateTLVersionLive = new UserPermission("91D4F496-48FB-4AE0-BBF9-D93D6B06DBE6",
            "Update TL Version: Live");

        public static readonly UserPermission ReportUpdateTLVersionOpenBeta = new UserPermission("CECEA497-52A7-4EF2-8B8C-FFE826FED802",
            "Update TL Version: Open Beta");

        public static readonly UserPermission ReportVDIMachineGrantAccess = new UserPermission("FACC9ACA-317F-422E-B75A-25A18FB793FE",
            "VDI Machine - Grant Access");

        public static readonly UserPermission ReportVDIMachineUpdateStatus = new UserPermission("C86D2BF1-CA4F-4F87-995E-A08924D6400F",
            "VDI Machine - Update Status");

        public static readonly UserPermission ReportUpdateClientVersion = new UserPermission("1B09EECD-B919-4BEB-8CCE-6CBED148931E",
            "Update Client Version");

        public UserPermission(string id, string name, bool isActive = true)
        {
            Id = id;
            Name = name;
            IsActive = isActive;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public static readonly UserPermission[] All =
        {
            ReadOnly,
            ActiveComputerDeleteOverride,
            AllowApplicationMerge,
            AllowCheckCore,
            AllowEditQuotes,
            AllowEmailTemplateCreationAndEditing,
            AllowGlobalEmailTemplate,
            AllowBulkEmailSending,
            AllowQuoteApprovalOnBehalfOfOrganization,
            AllowReassigningInCRM,
            AllowRedownloadCore,
            AllowViewCheckinHistory,
            AllowViewingPostSignedQuote,
            AllowEditQuoteAdditionalTerms,
            ApproveForEntireOrganization,
            ApproveForGroup,
            ApproveForSingleComputer,
            ApproveForSingleComputerApplicationOnly,
            AppTeam,
            ChangePermission,
            ChangeUserTierLevel,
            CyberHero,
            CyberHeroManagementProcessing,
            DeleteInvoices,
            EditAdministrators,
            EditApplicationCheckUpdatePoints,
            EditApplicationControlApplications,
            EditApplicationControlPolicies,
            EditBilling,
            EditComputerGroups,
            EditComputers,
            EditIntegrations,
            EditOrganizations,
            EditStorageControlPolicies,
            EditStorageControlStorageDevices,
            ElevationAdministrator,
            HelpDeskManagement,
            Invoicing,
            AllowIssueRefund,
            ManageBuiltInApplications,
            ManageHiddenApplications,
            ProductManagement,
            SalesEngineer,
            SalesManager,
            SalesPerson,
            SuperAdmin,
            SuperAdminChild,
            ViewAdministrators,
            ViewApplicationCheckUpdatePoints,
            ViewApprovals,
            ViewBilling,
            ViewDashboard,
            ViewDeploymentCenter,
            ViewHiddenPermissions,
            ViewOrganizations,
            ViewReports,
            ViewSystemAudit,
            ViewUnifiedAudit,
            EditLogonSettings,
            EditMultiLevelApprovals,
            ViewMultiLevelApprovals,
            CustomerBillingAccess,
            CRMDeletePayment,
            CRMTakeStripePayment,
            CRMExceedAmountDue,
            CRMSendInvoice,
            HelpDeskUnassignOwner,
            PromoteToGroup,
            PromoteToOrganization,
            RoleAdministrator,
            ExtendTrialPast60Days,
            AssignRoles,
            ViewOverrideCodes,
            AccountManager,
        };

        public static readonly UserPermission[] ApprovalPermissions =
        {
            ApproveForEntireOrganization,
            ApproveForGroup,
            ApproveForSingleComputer,
            ApproveForSingleComputerApplicationOnly,
            ElevationAdministrator,
            ViewApprovals
        };

        public static readonly UserPermission[] AdministratorPermissions =
        {
            AssignRoles,
            ChangePermission,
            EditAdministrators,
            EditLogonSettings,
            RoleAdministrator,
            ViewAdministrators
        };

        public static readonly UserPermission[] ApplicationControlPermissions =
        {
            EditApplicationControlApplications,
            EditApplicationControlPolicies,
            AllowApplicationMerge,
            PromoteToOrganization,
            PromoteToGroup,
            ManageTags
        };

        public static readonly UserPermission[] BillingPermissions =
        {
            ViewBilling,
            EditBilling
        };

        public static readonly UserPermission[] ComputerPermissions =
        {
            EditComputers,
            EditComputerGroups,
            ViewOverrideCodes
        };

        public static readonly UserPermission[] GeneralPermissions =
        {
            ViewSystemAudit,
            ViewUnifiedAudit,
            EditIntegrations,
            ReadOnly,
            ViewReports,
            ViewDeploymentCenter,
            SuperAdmin,
            SuperAdminChild,
            SuperAdminLoggedInOrganizationOnly
        };

        public static readonly UserPermission[] NetworkAccessControlPermissions =
        {
            EditNetworkAccessControlPolicies,
            EditNACAuthorizationHosts
        };

        public static readonly UserPermission[] OrganizationPermissions =
        {
            ViewOrganizations,
            EditOrganizations
        };

        public static readonly UserPermission[] StorageControlPermissions =
        {
            EditStorageControlPolicies,
            EditStorageControlStorageDevices
        };

        // Hidden Permissions
        public static readonly UserPermission[] MasterPermissions =
        {
            AccountManager,
            ActiveComputerDeleteOverride,
            AllowBulkEmailSending,
            AllowCheckCore,
            AllowEditQuoteAdditionalTerms,
            AllowEditQuotes,
            AllowViewingPostSignedQuote,
            AllowEmailTemplateCreationAndEditing,
            AllowGlobalEmailTemplate,
            AllowIssueRefund,
            AllowQuoteApprovalOnBehalfOfOrganization,
            AllowReassigningInCRM,
            AllowRedownloadCore,
            AllowViewCheckinHistory,
            AppTeam,
            ChangeUserTierLevel,
            CRMAllowSendingFromOtherUsers,
            DeleteInvoices,
            CRMDeletePayment,
            CRMEditOnetimeQuotes,
            CRMEditQuoteTerm,
            CRMEditReplaceQuotes,
            CRMExceedAmountDue,
            CRMExportContacts,
            CRMSendInvoice,
            CRMTakeStripePayment,
            CustomerBillingAccess,
            CyberHero,
            CyberHeroManagementProcessing,
            EditApplicationCheckUpdatePoints,
            EditMultiLevelApprovals,
            ExtendTrialPast60Days,
            HelpDeskManagement,
            HelpDeskResolveFromPage,
            HelpDeskUnassignOwner,
            Invoicing,
            LeadershipTeam,
            ManageBuiltInApplications,
            ManageEngineRules,
            ManageHiddenApplications,
            ProductManagement,
            SalesEngineer,
            SalesManager,
            SalesPerson,
            ViewApplicationCheckUpdatePoints,
            ViewDashboard,
            ViewHiddenPermissions,
            ViewMultiLevelApprovals
        };

        public static readonly UserPermission[] MasterReportPermissions =
        {
            ReportRevenue,
            ReportStaffFigures,
            ReportGenerateAPIKeys,
            ReportMarkInvoiceAsUnpaid,
            ReportNewThreatLockerVersion,
            ReportSyncMasterPermissions,
            ReportUpdateTLVersionAlphaToBeta,
            ReportUpdateTLVersionLive,
            ReportUpdateTLVersionOpenBeta,
            ReportVDIMachineGrantAccess,
            ReportVDIMachineUpdateStatus
        };

        public static readonly UserPermission[][] Categories =
        {
            ApprovalPermissions,
            AdministratorPermissions,
            ApplicationControlPermissions,
            BillingPermissions,
            ComputerPermissions,
            GeneralPermissions,
            NetworkAccessControlPermissions,
            OrganizationPermissions,
            StorageControlPermissions,
            MasterPermissions,
            MasterReportPermissions
        };

        public static UserPermission Find(string id)
        {
            foreach (var category in Categories)
            {
                foreach (var permission in category)
                {
                    if (permission.Id == id)
                    {
                        return permission;
                    }
                }
            }

            return null;
        }

        public static UserPermission Find(Guid id)
        {
            foreach (var category in Categories)
            {
                foreach (var permission in category)
                {
                    if (permission.Id.ToSafeGuid() == id)
                    {
                        return permission;
                    }
                }
            }

            return null;
        }

        public static UserPermission FindByName(string name)
        {
            foreach (var category in Categories)
            {
                foreach (var permission in category)
                {
                    if (permission.Name == name)
                    {
                        return permission;
                    }
                }
            }

            return null;
        }
    }
}
