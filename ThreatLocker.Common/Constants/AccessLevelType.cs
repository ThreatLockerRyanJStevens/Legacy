using System;
using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class AccessLevelType
    {
        public static readonly AccessLevelType ApplicationResearch = new AccessLevelType("Applications", "Permissions - Applications", Guid.Parse("7C68B752-EB1F-4A0E-A1FE-2E777D7DF1E2"), 1);
        public static readonly AccessLevelType ApplicationRestriction = new AccessLevelType("Applications", "RF applications", null, 1);

        public static readonly AccessLevelType FileResearch = new AccessLevelType("File", "Permissions - File", Guid.Parse("C3D5EE3E-6C91-49C5-B11B-1950B954AFFC"), 2);
        public static readonly AccessLevelType FileRestriction = new AccessLevelType("File", "RF File Access", null, 2);

        public static readonly AccessLevelType InternetResearch = new AccessLevelType("Internet", "Permissions - Internet", Guid.Parse("9D72F3C9-425B-49E8-82B9-ED76A6671CED"), 3);
        public static readonly AccessLevelType InternetRestriction = new AccessLevelType("Internet", "RF Internet", null, 3);

        public static readonly AccessLevelType RegistryResearch = new AccessLevelType("Registry", "Permissions - Registry", Guid.Parse("C0867F15-DF5A-4789-AF8D-C63666CFB9DF"), 4);
        public static readonly AccessLevelType RegistryRestriction = new AccessLevelType("Registry", "RF Registry", null, 4);

        public static readonly AccessLevelType WebDataResearch = new AccessLevelType("Web Data", "Permissions - Web Data", Guid.Parse("FDB35D30-B2C1-4ECB-8198-43A847E5B7A2"), 5);

        public static readonly AccessLevelType PasswordResearch = new AccessLevelType("Passwords", "Permissions - Password Access", Guid.Parse("FFEF0451-0BBA-4631-9B94-A877B8B7D09B"), 6);

        public string Name { get; }
        public string Value { get; }
        public Guid? Id { get; }
        public int OrderBy { get; }

        public AccessLevelType(string name, string value, Guid? id, int orderBy)
        {
            Name = name;
            Value = value;
            Id = id;
            OrderBy = orderBy;
        }

        public static readonly AccessLevelType[] All =
        {
            ApplicationResearch,
            ApplicationRestriction,
            FileResearch,
            FileRestriction,
            InternetResearch,
            InternetRestriction,
            PasswordResearch,
            RegistryResearch,
            RegistryRestriction,
            WebDataResearch,
        };

        public static readonly AccessLevelType[] ResearchTypes =
        {
            ApplicationResearch,
            FileResearch,
            InternetResearch,
            RegistryResearch,
            PasswordResearch,
            WebDataResearch,
        };

        public static readonly AccessLevelType[] RestrictionTypes =
        {
            ApplicationRestriction,
            FileRestriction,
            InternetRestriction,
            RegistryRestriction,
        };

        public static AccessLevelType Find(string name)
        {
            return All.FirstOrDefault(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public static AccessLevelType FindByValue(string value)
        {
            return All.FirstOrDefault(x => x.Value.Equals(value, StringComparison.OrdinalIgnoreCase));
        }

        public static AccessLevelType FindById(Guid id)
        {
            return All.Where(x => x.Id.HasValue).FirstOrDefault(x => x.Id.Value == id);
        }
    }
}
