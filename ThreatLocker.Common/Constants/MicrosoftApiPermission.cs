using System;
using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class MicrosoftApiPermission
    {
        public static readonly MicrosoftApiPermission OrganizationReadAll = new MicrosoftApiPermission(Guid.Parse("498476ce-e0fe-48b0-b801-37ba7e2685c6"), "Organization.Read.All");
        public static readonly MicrosoftApiPermission UserReadAll = new MicrosoftApiPermission(Guid.Parse("df021288-bdef-4463-88db-98f22de89214"), "User.Read.All");
        public static readonly MicrosoftApiPermission DeviceReadAll = new MicrosoftApiPermission(Guid.Parse("7438b122-aefc-4978-80ed-43db9fcc7715"), "Device.Read.All");
        public static readonly MicrosoftApiPermission UserEnableDisableAccountAll = new MicrosoftApiPermission(Guid.Parse("3011c876-62b7-4ada-afa2-506cbbecc68c"), "User.EnableDisableAccount.All");
        public static readonly MicrosoftApiPermission SecurityAlertReadAll = new MicrosoftApiPermission(Guid.Parse("472e4a4d-bb4a-4026-98d1-0b0d74cb74a5"), "SecurityAlert.Read.All");
        public static readonly MicrosoftApiPermission AuditLogReadAll = new MicrosoftApiPermission(Guid.Parse("b0afded3-3588-46d8-8b3d-9842eff778da"), "AuditLog.Read.All");
        public static readonly MicrosoftApiPermission IdentityRiskEventReadAll = new MicrosoftApiPermission(Guid.Parse("6e472fd1-ad78-48da-a0f0-97ab2c6b769e"), "IdentityRiskEvent.Read.All");
        public static readonly MicrosoftApiPermission ActivityFeedRead = new MicrosoftApiPermission(Guid.Parse("594c1fb6-4f81-4475-ae41-0c394909246c"), "ActivityFeed.Read");
        public static readonly MicrosoftApiPermission ActivityFeedReadDlp = new MicrosoftApiPermission(Guid.Parse("4807a72c-ad38-4250-94c9-4eabfe26cd55"), "ActivityFeed.ReadDlp");
        public static readonly MicrosoftApiPermission ServiceHealthRead = new MicrosoftApiPermission(Guid.Parse("e2cea78f-e743-4d8f-a16a-75b629a038ae"), "ServiceHealth.Read");

        public MicrosoftApiPermission(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public static readonly MicrosoftApiPermission[] All =
        {
            OrganizationReadAll,
            UserReadAll,
            DeviceReadAll,
            UserEnableDisableAccountAll,
            SecurityAlertReadAll,
            AuditLogReadAll,
            IdentityRiskEventReadAll,
            ActivityFeedRead,
            ActivityFeedReadDlp,
            ServiceHealthRead,
        };

        public static readonly string[] Default =
        {
            OrganizationReadAll.Name,
            UserReadAll.Name,
            DeviceReadAll.Name,
            UserEnableDisableAccountAll.Name,
        };

        public static readonly string[] MicrosoftGraph =
        {
            SecurityAlertReadAll.Name,
            AuditLogReadAll.Name,
            IdentityRiskEventReadAll.Name,
        };

        public static readonly string[] Office365Management =
        {
            ActivityFeedRead.Name,
            ActivityFeedReadDlp.Name,
            ServiceHealthRead.Name,
        };

        public static MicrosoftApiPermission Find(Guid id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static MicrosoftApiPermission FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}