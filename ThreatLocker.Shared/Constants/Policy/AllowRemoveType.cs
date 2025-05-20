using System.Linq;

namespace ThreatLocker.Shared.Constants.Policy
{
    public class AllowRemoveType
    {
        public static readonly AllowRemoveType Yes = new AllowRemoveType(true, "yes");
        public static readonly AllowRemoveType No = new AllowRemoveType(false, "no");

        public AllowRemoveType(bool id, string name)
        {
            Id = id;
            Name = name;
        }

        public bool Id { get; set; }
        public string Name { get; set; }

        public static readonly AllowRemoveType[] All =
       {
            Yes,
            No
       };

        public static AllowRemoveType Find(bool id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static AllowRemoveType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
