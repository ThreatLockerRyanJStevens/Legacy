using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class ApplicationSearchByType
    {
        public static readonly ApplicationSearchByType ApplicationName = new ApplicationSearchByType("app", "Application Name");
        public static readonly ApplicationSearchByType FullPath = new ApplicationSearchByType("full", "Full Path");
        public static readonly ApplicationSearchByType ProcessPath = new ApplicationSearchByType("process", "Process Path");
        public static readonly ApplicationSearchByType Hash = new ApplicationSearchByType("hash", "Hash");
        public static readonly ApplicationSearchByType Certificate = new ApplicationSearchByType("cert", "Certificate");
        public static readonly ApplicationSearchByType CreatedBy = new ApplicationSearchByType("created", "Created By");
        public static readonly ApplicationSearchByType Category = new ApplicationSearchByType("categories", "Category");
        public static readonly ApplicationSearchByType CountryOfOperation = new ApplicationSearchByType("countries", "Country of Operation");

        public ApplicationSearchByType(string value, string name)
        {
            Value = value;
            Name = name;
        }

        public string Value { get; set; }
        public string Name { get; set; }

        public static readonly ApplicationSearchByType[] All =
        {
            ApplicationName,
            FullPath,
            ProcessPath,
            Hash,
            Certificate,
            CreatedBy,
            Category,
            CountryOfOperation
        };

        public static readonly string[] AllOSTypes =
        {
            ApplicationName.Value,
            Category.Value,
            CountryOfOperation.Value
        };

        public static ApplicationSearchByType Find(string value)
        {
            return All.FirstOrDefault(x => x.Value == value);
        }

        public static ApplicationSearchByType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }

    }
}
