using System.Linq;

namespace ThreatLocker.Shared.Constants.LogonRestrinction
{
    public class LogonRestrinctionType
    {
        public static readonly LogonRestrinctionType AllowAll = new LogonRestrinctionType(0, "Allow All");
        public static readonly LogonRestrinctionType AllowSelected = new LogonRestrinctionType(1, "Allow Selected");
        public static readonly LogonRestrinctionType BlockSelected = new LogonRestrinctionType(2, "Block Selected");

        public LogonRestrinctionType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly LogonRestrinctionType[] All =
       {
            AllowAll,
            AllowSelected,
            BlockSelected
       };

        public static LogonRestrinctionType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static LogonRestrinctionType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }

    }
}
