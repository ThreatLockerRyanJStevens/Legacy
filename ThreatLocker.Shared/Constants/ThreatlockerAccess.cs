using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class ThreatlockerAccess
    {
        public static readonly ThreatlockerAccess None = new ThreatlockerAccess(0, "None");
        public static readonly ThreatlockerAccess ReadOnly = new ThreatlockerAccess(1, "Read Only");
        public static readonly ThreatlockerAccess FullControl = new ThreatlockerAccess(2, "Full Control");

        public ThreatlockerAccess(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly ThreatlockerAccess[] All =
        {
            None,
            ReadOnly,
            FullControl
        };

        public static ThreatlockerAccess Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }
    }
}
