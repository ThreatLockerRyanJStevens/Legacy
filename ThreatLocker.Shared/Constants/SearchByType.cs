using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class SearchByType
    {
        public static readonly SearchByType App = new SearchByType(1, "app");
        public static readonly SearchByType Description = new SearchByType(2, "descript");

        public SearchByType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly SearchByType[] All =
        {
            App,
            Description
        };

        public static SearchByType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static SearchByType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
