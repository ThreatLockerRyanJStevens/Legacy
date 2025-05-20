namespace ThreatLocker.Shared.Constants
{
    public class ItemIdCheckType
    {
        public static readonly ItemIdCheckType Application = new ItemIdCheckType(1, "Application", "Guid");
        public static readonly ItemIdCheckType ApplicationFile = new ItemIdCheckType(2, "ApplicationFile", "Long");
        public static readonly ItemIdCheckType ApplicationPolicy = new ItemIdCheckType(3, "ApplicationPolicy", "Guid");
        public static readonly ItemIdCheckType ApprovalRequest = new ItemIdCheckType(4, "ApprovalRequest", "Guid");
        public static readonly ItemIdCheckType Integration = new ItemIdCheckType(5, "Integration", "Guid");
        public static readonly ItemIdCheckType StorageDevice = new ItemIdCheckType(6, "StorageDevice", "Guid");
        public static readonly ItemIdCheckType StoragePolicy = new ItemIdCheckType(7, "StoragePolicy", "Guid");
        public static readonly ItemIdCheckType AuthorizationHost = new ItemIdCheckType(8, "AuthorizationHost", "Guid");
        public static readonly ItemIdCheckType OrgBillingContact = new ItemIdCheckType(9, "OrgBillingContact", "Guid");
        public static readonly ItemIdCheckType Tag = new ItemIdCheckType(10, "Tag", "Guid");
        public static readonly ItemIdCheckType CommunityThreatOpsPolicy = new ItemIdCheckType(11, "CommunityThreatOpsPolicy", "Guid");
        public static readonly ItemIdCheckType NetworkAccessPolicy = new ItemIdCheckType(12, "NetworkAccessPolicy", "Guid");
        public static readonly ItemIdCheckType HealthCenter = new ItemIdCheckType(13, "HealthCenter", "Guid");
        public static readonly ItemIdCheckType HelpDeskTicket = new ItemIdCheckType(14, "HelpDeskTicket", "Guid");
        public static readonly ItemIdCheckType ThreatOpsPolicy = new ItemIdCheckType(15, "ThreatOpsPolicy", "Guid");
        public static readonly ItemIdCheckType TWPolicy = new ItemIdCheckType(16, "TWPolicy", "Guid");
        public static readonly ItemIdCheckType SaveSearch = new ItemIdCheckType(17, "SaveSearch", "Guid");
        public static readonly ItemIdCheckType Computer = new ItemIdCheckType(18, "Computer", "Guid");
        public static readonly ItemIdCheckType ComputerGroup = new ItemIdCheckType(19, "ComputerGroup", "Guid");
        public static readonly ItemIdCheckType TrayPolicyContent = new ItemIdCheckType(20, "TrayPolicyContent", "Guid");
        public static readonly ItemIdCheckType AuthToken = new ItemIdCheckType(21, "AuthToken", "string");
        public static readonly ItemIdCheckType Organization = new ItemIdCheckType(22, "Organization", "Guid");
        public static readonly ItemIdCheckType OrganizationDomain = new ItemIdCheckType(23, "OrganizationDomain", "Guid");
        public static readonly ItemIdCheckType User = new ItemIdCheckType(24, "User", "Guid");
        public static readonly ItemIdCheckType UserRoles = new ItemIdCheckType(25, "UserRoles", "Guid");
        public static readonly ItemIdCheckType MacApplicationPolicy = new ItemIdCheckType(26, "MacApplicationPolicy", "Guid");
        public static readonly ItemIdCheckType OpsPolicy = new ItemIdCheckType(27, "OpsPolicy", "Guid");
        public static readonly ItemIdCheckType OpsAlert = new ItemIdCheckType(28, "OpsAlert", "Guid");
        public static readonly ItemIdCheckType OpsPolicyExclusion = new ItemIdCheckType(29, "OpsPolicyExclusion", "Long");
        public static readonly ItemIdCheckType MacApplicationFile = new ItemIdCheckType(30, "MacApplicationFile", "Long");
        public static readonly ItemIdCheckType CommunityOrganization = new ItemIdCheckType(31, "CommunityOrganization", "Guid");
        public static readonly ItemIdCheckType CommunityItem = new ItemIdCheckType(32, "CommunityItem", "Guid");
        public static readonly ItemIdCheckType CommunitySourceItem = new ItemIdCheckType(33, "CommunitySourceItem", "Guid");
        public static readonly ItemIdCheckType Configuration = new ItemIdCheckType(34, "Configuration", "Guid");
        public static readonly ItemIdCheckType RemediationPolicy = new ItemIdCheckType(35, "RemediationPolicy", "Guid");
        public static readonly ItemIdCheckType CMPolicy = new ItemIdCheckType(36, "CMPolicy", "Guid");
        public static readonly ItemIdCheckType TouchPoint = new ItemIdCheckType(37, "TouchPoint", "Guid");
        public static readonly ItemIdCheckType OpsAlertComputer = new ItemIdCheckType(38, "OpsAlertComputer", "Guid");
        public static readonly ItemIdCheckType ProductTrial = new ItemIdCheckType(39, "ProductTrial", "Guid");
        public static readonly ItemIdCheckType ComputerLocalAdmin = new ItemIdCheckType(39, "ComputerLocalAdmin", "Long");
        public static readonly ItemIdCheckType CRMTaxCertificate = new ItemIdCheckType(40, "CRMTaxCertificate", "Guid");
        public static readonly ItemIdCheckType CustomBannerMessage = new ItemIdCheckType(41, "CustomBannerMessage", "Guid");
        public static readonly ItemIdCheckType OrganizationBillingAddress = new ItemIdCheckType(42, "OrganizationBillingAddress", "Guid");
        public static readonly ItemIdCheckType AccessDevice = new ItemIdCheckType(43, "AccessDevice", "Guid");
        public static readonly ItemIdCheckType CloudDetectPolicy = new ItemIdCheckType(44, "CloudDetectPolicy", "Guid");
        public static readonly ItemIdCheckType CloudDetectPolicyExclusion = new ItemIdCheckType(45, "CloudDetectPolicyExclusion", "Long");
        public static readonly ItemIdCheckType CloudDetectAlert = new ItemIdCheckType(46, "CloudDetectAlert", "Guid");
        public static readonly ItemIdCheckType CloudDetectAlertObject = new ItemIdCheckType(47, "CloudDetectAlertObject", "string");
        public static readonly ItemIdCheckType NamedLocation = new ItemIdCheckType(48, "NamedLocation", "Guid");
        public static readonly ItemIdCheckType WebControlPolicy = new ItemIdCheckType(48, "WebControlPolicy", "Guid");        
        public static readonly ItemIdCheckType PatchTransaction = new ItemIdCheckType(49, "PatchTransaction", "long");
        public static readonly ItemIdCheckType PatchPolicy = new ItemIdCheckType(50, "PatchPolicy", "Guid");
        public static readonly ItemIdCheckType WebControlRegisteredDnsServer = new ItemIdCheckType(51, "WebControlRegisteredDnsServer", "Guid");

        public ItemIdCheckType(int id, string name, string idType)
        {
            Id = id;
            Name = name;
            IdType = idType;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string IdType { get; set; }
    }
}
