using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class PasswordScoreType
    {
        public static readonly PasswordScoreType Blank = new PasswordScoreType(0, "Blank");
        public static readonly PasswordScoreType VeryWeak = new PasswordScoreType(1, "VeryWeak");
        public static readonly PasswordScoreType Weak = new PasswordScoreType(2, "Weak");
        public static readonly PasswordScoreType Medium = new PasswordScoreType(3, "Medium");
        public static readonly PasswordScoreType Strong = new PasswordScoreType(4, "Strong");
        public static readonly PasswordScoreType VeryStrong = new PasswordScoreType(5, "VeryStrong");

        public PasswordScoreType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly PasswordScoreType[] All =
        {
            Blank,
            VeryWeak,
            Weak, 
            Medium, 
            Strong,
            VeryStrong
        };

        public static PasswordScoreType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static PasswordScoreType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
