using System;
using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class SharePointApiPermission
    {
        public static readonly SharePointApiPermission OrganizationReadAll = new SharePointApiPermission(Guid.Parse("498476ce-e0fe-48b0-b801-37ba7e2685c6"), "Organization.Read.All");
        public static readonly SharePointApiPermission UserReadAll = new SharePointApiPermission(Guid.Parse("df021288-bdef-4463-88db-98f22de89214"), "User.Read.All");
        public static readonly SharePointApiPermission DeviceReadAll = new SharePointApiPermission(Guid.Parse("7438b122-aefc-4978-80ed-43db9fcc7715"), "Device.Read.All");
        public static readonly SharePointApiPermission ActivityFeedRead = new SharePointApiPermission(Guid.Parse("594c1fb6-4f81-4475-ae41-0c394909246c"), "ActivityFeed.Read");
        public static readonly SharePointApiPermission FilesReadAll = new SharePointApiPermission(Guid.Parse("01d4889c-1287-42c6-ac1f-5d1e02578ef6"), "Files.Read.All");
        public static readonly SharePointApiPermission SitesReadAll = new SharePointApiPermission(Guid.Parse("332a536c-c7ef-4017-ab91-336970924f0d"), "Sites.Read.All");

        public SharePointApiPermission(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public static readonly SharePointApiPermission[] All =
        {
            OrganizationReadAll,
            UserReadAll,
            DeviceReadAll,
            ActivityFeedRead,
            FilesReadAll,
            SitesReadAll,
        };

        public static readonly string[] AllNames =
        {
            OrganizationReadAll.Name,
            UserReadAll.Name,
            DeviceReadAll.Name,
            ActivityFeedRead.Name,
            FilesReadAll.Name,
            SitesReadAll.Name,
        };

        public static SharePointApiPermission Find(Guid id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static SharePointApiPermission FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}