using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class HelpDeskUploadStatusType
    {
        public static readonly HelpDeskUploadStatusType Uploaded = new HelpDeskUploadStatusType(1, "uploaded");
        public static readonly HelpDeskUploadStatusType FileInformationMissing = new HelpDeskUploadStatusType(2, "fileinformationmissing");
        public static readonly HelpDeskUploadStatusType FileMissing = new HelpDeskUploadStatusType(3, "filemissing");
        public static readonly HelpDeskUploadStatusType UploadedAlready = new HelpDeskUploadStatusType(4, "filepresent");
        public static readonly HelpDeskUploadStatusType FailedToSave = new HelpDeskUploadStatusType(5, "failedtosave");
        public static readonly HelpDeskUploadStatusType ShadoesNotMatch = new HelpDeskUploadStatusType(6, "shadoesnotmatch");//it happens if not possible calculate the size of file

        public HelpDeskUploadStatusType(int value, string name)
        {
            Value = value;
            Name = name;
        }

        public int Value { get; set; }
        public string Name { get; set; }

        public static readonly HelpDeskUploadStatusType[] All =
       {
            Uploaded,
            FileInformationMissing,
            FileMissing,
            UploadedAlready,
            FailedToSave,
            ShadoesNotMatch
        };

        public static HelpDeskUploadStatusType Find(int value)
        {
            return All.FirstOrDefault(x => x.Value == value);
        }

        public static HelpDeskUploadStatusType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
