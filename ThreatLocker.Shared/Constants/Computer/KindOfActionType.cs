using System.Linq;

namespace ThreatLocker.Shared.Constants.Computer
{
    public class KindOfActionType
    {
        public static readonly KindOfActionType ComputerMode = new KindOfActionType(1, "Computer Mode");
        public static readonly KindOfActionType TamperProtectionDisabled = new KindOfActionType(2, "TamperProtectionDisabled");
        public static readonly KindOfActionType NeedsReview = new KindOfActionType(3, "NeedsReview");
        public static readonly KindOfActionType ReadyToSecure = new KindOfActionType(4, "ReadyToSecure");
        public static readonly KindOfActionType BaselineNotUploaded = new KindOfActionType(5, "BaselineNotUploaded");
        public static readonly KindOfActionType UpdateChannel = new KindOfActionType(6, "Update Channel");

        public KindOfActionType(int value, string name)
        {
            Value = value;
            Name = name;
        }

        public int Value { get; set; }
        public string Name { get; set; }

        public static readonly KindOfActionType[] All =
       {
            ComputerMode,
            TamperProtectionDisabled,
            NeedsReview,
            ReadyToSecure,
            BaselineNotUploaded,
            UpdateChannel
        };

        public static KindOfActionType Find(int value)
        {
            return All.FirstOrDefault(x => x.Value == value);
        }

        public static KindOfActionType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());
        }
    }
}
