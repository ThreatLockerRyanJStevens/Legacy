using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class HelpDeskReadTranscriptType
    {
        public static readonly HelpDeskReadTranscriptType Success = new HelpDeskReadTranscriptType(1, "Success");
        public static readonly HelpDeskReadTranscriptType Failure = new HelpDeskReadTranscriptType(2, "Failure");
        public static readonly HelpDeskReadTranscriptType NotFound = new HelpDeskReadTranscriptType(3, "Not Found");

        public HelpDeskReadTranscriptType(int value, string name)
        {
            Value = value;
            Name = name;
        }

        public int Value { get; set; }
        public string Name { get; set; }

        public static readonly HelpDeskReadTranscriptType[] All =
        {
            Success,
            Failure,
            NotFound
        };

        public static HelpDeskReadTranscriptType Find(int value)
        {
            return All.FirstOrDefault(x => x.Value == value);
        }

        public static HelpDeskReadTranscriptType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
