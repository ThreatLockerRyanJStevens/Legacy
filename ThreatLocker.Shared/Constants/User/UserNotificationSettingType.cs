using System.Linq;

namespace ThreatLocker.Shared.Constants.User
{
    public class UserNotificationSettingType
    {
        public static readonly UserNotificationSettingType None = new UserNotificationSettingType(0, "None");
        public static readonly UserNotificationSettingType Email = new UserNotificationSettingType(1, "Email");
        public static readonly UserNotificationSettingType SMS = new UserNotificationSettingType(2, "SMS");
        public static readonly UserNotificationSettingType EmailSMS = new UserNotificationSettingType(3, "Email and SMS");

        public UserNotificationSettingType(int value, string name)
        {
            Value = value;
            Name = name;
        }

        public int Value { get; set; }
        public string Name { get; set; }

        public static readonly UserNotificationSettingType[] All =
        {
            None,
            Email,
            SMS,
            EmailSMS
        };

        public static UserNotificationSettingType Find(int value)
        {
            return All.FirstOrDefault(x => x.Value == value);
        }

        public static UserNotificationSettingType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());
        }
    }
}
