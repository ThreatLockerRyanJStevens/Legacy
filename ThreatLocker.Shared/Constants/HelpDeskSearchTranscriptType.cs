using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class HelpDeskSearchTranscriptType
    {
        public static readonly HelpDeskSearchTranscriptType ThreeTimes = new HelpDeskSearchTranscriptType(3, "Three");
        public static readonly HelpDeskSearchTranscriptType FourTimes = new HelpDeskSearchTranscriptType(4, "Four");
        public static readonly HelpDeskSearchTranscriptType FiveTimes = new HelpDeskSearchTranscriptType(5, "Five");

        public HelpDeskSearchTranscriptType(int value, string name)
        {
            Value = value;
            Name = name;
        }

        public int Value { get; set; }
        public string Name { get; set; }

        public static readonly HelpDeskSearchTranscriptType[] All =
        {
            ThreeTimes,
            FourTimes,
            FiveTimes
        };

        public static HelpDeskSearchTranscriptType Find(int value)
        {
            return All.FirstOrDefault(x => x.Value == value);
        }

        public static HelpDeskSearchTranscriptType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
