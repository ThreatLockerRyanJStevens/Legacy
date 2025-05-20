

using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class EncryptionStatusType
    {
        public static readonly EncryptionStatusType NotEncrypted = new EncryptionStatusType(0, "Not Encrypted");
        public static readonly EncryptionStatusType Encrypted = new EncryptionStatusType(1, "Encrypted");
        public static readonly EncryptionStatusType Both = new EncryptionStatusType(3, "Both Encrypted and Not Encrypted");

        public EncryptionStatusType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly EncryptionStatusType[] All =
        {
            NotEncrypted,
            Encrypted,
            Both
        };

        // Optional Find method.
        public static EncryptionStatusType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }
    }
}
