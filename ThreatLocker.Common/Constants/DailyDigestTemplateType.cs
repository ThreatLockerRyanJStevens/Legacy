using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class DailyDigestTemplateType
    {
        public static readonly DailyDigestTemplateType MainTemplate = new DailyDigestTemplateType(1, "Main Template");
        public static readonly DailyDigestTemplateType RecordTable = new DailyDigestTemplateType(2, "Daily Digest - Record Table");
        public static readonly DailyDigestTemplateType Scripts = new DailyDigestTemplateType(3, "Daily Digest - Scripts Daily Digest");
        public static readonly DailyDigestTemplateType EmailBody = new DailyDigestTemplateType(4, "Daily Digest - Email - Body");

        public DailyDigestTemplateType(long id, string name)
        {
            Id = id;
            Name = name;
        }

        public long Id { get; }
        public string Name { get; }

        public static readonly DailyDigestTemplateType[] All =
        {
            MainTemplate,
            RecordTable,
            Scripts,
            EmailBody
        };

        public static DailyDigestTemplateType Find(long id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static DailyDigestTemplateType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
