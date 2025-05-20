using System;
using System.Collections.Generic;

namespace ThreatLockerCommon.Constants
{
    public class MenuId
    {
        public static Guid Administrators => new Guid("4351FD77-FB18-49E9-A128-700F0E1E46CA");
        public static Guid ApplicationControl => new Guid("06C88104-69E3-4F58-921D-8C110F2D77B6");
        public static Guid ApplicationChecks => new Guid("C5CBF632-F99F-4493-9F3D-DCB8A140DC74");
        public static Guid Applications => new Guid("A84BB3C6-4D41-4849-AACD-D75B32BF383E");
        public static Guid ApplicationTeam => new Guid("F32261D4-527E-4541-8CF4-9BCDFC5B9BAF");
        public static Guid ApprovalCenter => new Guid("C1B49EBD-2E97-4D27-90DD-55C943DECE96");
        public static Guid AuthorizationHost => new Guid("DC40CB15-2009-4F31-A9FB-E06986DE23F1");
        public static Guid Billing => new Guid("02D102D0-FCF0-4217-A400-E8D220B9BF2F");
        public static Guid ComputerGroups => new Guid("4F09DCBD-4873-4A25-904D-383DC4965B62");
        public static Guid Computers => new Guid("F31CB826-36E3-411D-8B26-367A47600E9C");
        public static Guid Contacts => new Guid("0660C474-2720-4775-8B6C-458ED318BD49");
        public static Guid CustomerRelations => new Guid("038BBF1F-0063-4548-A9F2-664732A75E1C");
        public static Guid Dashboard => new Guid("6151E552-580F-4A80-BD7C-AEE127475EE9");
        public static Guid DeploymentCenter => new Guid("6DF14383-277E-443A-9CEF-CBAF9DB7060E");
        public static Guid HelpAndSupport => new Guid("0F5A9E21-9937-4D23-A960-9E92EAB4506A");
        public static Guid HelpDesk => new Guid("6FFFE20A-47EA-4FD8-87FE-36BCA452A8CD");
        public static Guid Integrations => new Guid("BDC1AE6E-879A-447E-9F9F-73F0AA9ECEA0");
        public static Guid Invoicing => new Guid("6C68FE40-8E63-4E5E-BA87-D26738E2CB8E");
        public static Guid KnowledgeBase => new Guid("D4A1AF16-A5F0-475B-8101-94A86C157299");
        public static Guid LegacyInvoicing => new Guid("0D73A1EC-7293-414F-B025-B9F1B316BB91");
        public static Guid SecurityCenter => new Guid("065D769D-4ABC-46C1-AD2B-FC2EB3C71FCE");
        public static Guid Mail => new Guid("493ADE95-2AE1-4F29-9BE0-9273AB93E3F0");
        public static Guid MissingHash => new Guid("E9DAB9FC-EBA1-4A4D-A673-1C50F43DCE04");
        public static Guid MultiLevelApproval => new Guid("2F786FBF-E13E-45D5-9FB2-0C8A497E2CE8");
        public static Guid NetworkAccessControl => new Guid("D708CB79-F2ED-4D25-8E09-2AC80B9C4288");
        public static Guid Organizations => new Guid("BD90A0CB-798F-4961-B74A-3A86C592AD89");
        public static Guid CRMOrganizations => new Guid("08DA709E-115F-4A79-AB01-FD432E2D67F5");
        public static Guid PartnerResource => new Guid("07A3F6D0-6404-4C9B-A8B8-B8352C0DC8A0");
        public static Guid PermittedApplications => new Guid("49CB02BE-7E3A-49E7-8404-53E83E9BA3EA");
        public static Guid StoragePolicies => new Guid("0AFB3D35-0D2A-4429-9C87-76E2246B0C84");
        public static Guid NetworkAccessPolicies => new Guid("3E8A4474-ED6A-4A9C-8A2F-D609BAD23965");
        public static Guid ApplicationPolicies => new Guid("71B89B6D-3DC0-44E8-BABF-A9EF2E75B4A4");
        public static Guid Reports => new Guid("6C98DE07-90EF-4D98-96A2-B13B49EBB4F5");
        public static Guid Security => new Guid("F30C1D0C-B97C-404F-86F1-8CFFD9847A11");
        public static Guid StorageControl => new Guid("14948793-9B74-4546-9E75-F05130B0F8AA");
        public static Guid StorageDevices => new Guid("CB993AB6-7932-4169-BB51-E7C532EFEFB6");
        public static Guid SystemAudit => new Guid("7BD79A5B-B9C2-4F11-8FFE-2C579CE0495F");
        public static Guid Tags => new Guid("33C4CA75-8234-4287-8D23-3E33298D935D");
        public static Guid ThreatLockerUniversity => new Guid("461970AA-CB36-4BBF-B3EF-7A1A1E955B9C");
        public static Guid UnifiedAudit => new Guid("BC3DC2F0-BB62-4CAA-8519-D9FB2C69D49A");
        public static Guid UniversityStaffPortal => new Guid("388CB591-8868-418A-B790-2EDCCB97C0D5");
        public static Guid UserRoles => new Guid("44A540D6-2C99-4848-B68A-B9F6771B88E8");

        public static readonly Guid[] ExternalItems = {
            ThreatLockerUniversity,
            UniversityStaffPortal,
            KnowledgeBase
        };
    }
}
