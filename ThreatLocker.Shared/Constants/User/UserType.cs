using System.Linq;

namespace ThreatLocker.Shared.Constants.User
{
    public class UserType
    {
        public static readonly UserType Default = new UserType(0, "Default");
        public static readonly UserType APIUser = new UserType(1, "APIUser");
        
        public UserType(int value, string name)
        {
            Value = value;
            Name = name;
        }

        public int Value { get; set; }
        public string Name { get; set; }

        public static readonly UserType[] All =
       {
            Default,
            APIUser
        };

        public static UserType Find(int value)
        {
            return All.FirstOrDefault(x => x.Value == value);
        }

        public static UserType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());
        }
    }
}
