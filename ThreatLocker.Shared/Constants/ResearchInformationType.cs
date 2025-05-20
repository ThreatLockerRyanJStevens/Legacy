using System;
using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class ResearchInformationType
    {
        public static readonly ResearchInformationType PermissionsApplications = new ResearchInformationType(Guid.Parse("7C68B752-EB1F-4A0E-A1FE-2E777D7DF1E2"),
            "Permissions - Applications");
        public static readonly ResearchInformationType PermissionsCameraAccess = new ResearchInformationType(Guid.Parse("A34E1D9F-B5E1-4467-AE61-7764120C7FBF"), 
            "Permissions - Camera Access");
        public static readonly ResearchInformationType PermissionsFile = new ResearchInformationType(Guid.Parse("C3D5EE3E-6C91-49C5-B11B-1950B954AFFC"),
            "Permissions - File");
        public static readonly ResearchInformationType PermissionsInternet = new ResearchInformationType(Guid.Parse("9D72F3C9-425B-49E8-82B9-ED76A6671CED"), 
            "Permissions - Internet");
        public static readonly ResearchInformationType PermissionsMicrophoneAccess = new ResearchInformationType(Guid.Parse("235EA7C2-8D82-4C2D-B88C-227D405F52E7"), 
            "Permissions - Microphone Access");
        public static readonly ResearchInformationType PermissionsWebData = new ResearchInformationType(Guid.Parse("FDB35D30-B2C1-4ECB-8198-43A847E5B7A2"), 
            "Permissions - Web Data");
        public static readonly ResearchInformationType PermissionsPasswordAccess = new ResearchInformationType(Guid.Parse("FFEF0451-0BBA-4631-9B94-A877B8B7D09B"), 
            "Permissions - Password Access");
        public static readonly ResearchInformationType PermissionsRegistry = new ResearchInformationType(Guid.Parse("C0867F15-DF5A-4789-AF8D-C63666CFB9DF"),
            "Permissions - Registry");
        public static readonly ResearchInformationType Category = new ResearchInformationType(Guid.Parse("7CAEE11B-2791-41F4-B45C-7E130DC484AD"), 
            "Category");
        public static readonly ResearchInformationType CompanyEmployeeCount = new ResearchInformationType(Guid.Parse("77736DE1-E604-46CB-9220-5EC4604F0131"), 
            "Company Employee Count");
        public static readonly ResearchInformationType CountryOfOrigin = new ResearchInformationType(Guid.Parse("87C6ABBF-AC81-48A2-A9B2-8CB469251ACE"), 
            "Country Of Origin");
        public static readonly ResearchInformationType CountrysOfOperation = new ResearchInformationType(Guid.Parse("3BBE7A26-9482-4219-93ED-CD3524DB5495"), 
            "Country(s) Of Operation");
        public static readonly ResearchInformationType CodeCompileLocation = new ResearchInformationType(Guid.Parse("2477A46E-08BC-4967-865D-817635828B9E"),
            "Where Code Is Compiled");

        public static readonly int Protected = 0;
        public static readonly int Unprotected = 1;

        public ResearchInformationType(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public static readonly ResearchInformationType[] All =
        {
            PermissionsApplications,
            PermissionsCameraAccess,
            PermissionsFile,
            PermissionsInternet,
            PermissionsMicrophoneAccess,
            PermissionsWebData,
            PermissionsPasswordAccess,
            PermissionsRegistry,
            Category,
            CompanyEmployeeCount,
            CountryOfOrigin,
            CountrysOfOperation
        };

        public static readonly Guid[] Permissions =
        {
            PermissionsApplications.Id,
            PermissionsFile.Id,
            PermissionsInternet.Id,
            PermissionsRegistry.Id,
            PermissionsWebData.Id,
            PermissionsPasswordAccess.Id
        };

        //Optional Find method
        public static ResearchInformationType Find(Guid id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        //Optional Find method
        public static ResearchInformationType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }

    }
}
