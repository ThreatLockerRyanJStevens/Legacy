using System.Linq;

namespace ThreatLocker.Shared.Constants.Application
{
    public class ApplicationFileType
    {
        public static readonly ApplicationFileType FullPath = new ApplicationFileType(1, "Full Path");
        public static readonly ApplicationFileType ProcessPath = new ApplicationFileType(2, "Process Path");
        public static readonly ApplicationFileType Certificate = new ApplicationFileType(3, "Certificate");
        public static readonly ApplicationFileType Hash = new ApplicationFileType(4, "Hash");
        public static readonly ApplicationFileType CreatedBy = new ApplicationFileType(5, "Created By");

        public ApplicationFileType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly ApplicationFileType[] All =
        {
            FullPath,
            ProcessPath,
            Certificate,
            Hash,
            CreatedBy
        };

        public static ApplicationFileType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static ApplicationFileType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
