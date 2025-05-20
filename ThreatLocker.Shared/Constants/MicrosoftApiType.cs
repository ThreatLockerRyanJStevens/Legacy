using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class MicrosoftApiType
    {
        public static readonly MicrosoftApiType Default = new MicrosoftApiType(0, "Default");
        public static readonly MicrosoftApiType MicrosoftGraph = new MicrosoftApiType(1, "Microsoft Graph");
        public static readonly MicrosoftApiType Office365Management = new MicrosoftApiType(2, "Office 365 Management");

        public MicrosoftApiType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly MicrosoftApiType[] All =
        {
            Default,
            MicrosoftGraph,
            Office365Management,
        };

        public static MicrosoftApiType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static MicrosoftApiType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
