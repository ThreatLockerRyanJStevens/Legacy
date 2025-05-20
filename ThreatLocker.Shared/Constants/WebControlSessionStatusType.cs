namespace ThreatLocker.Shared.Constants
{
    public class WebControlSessionStatusType
    {
        public static readonly WebControlSessionStatusType Active = new(0, "Active");
        public static readonly WebControlSessionStatusType Used = new(1, "Used");
        public static readonly WebControlSessionStatusType Expired = new(2, "Expired");
        public static readonly WebControlSessionStatusType Revoked = new(3, "Revoked");
        public static readonly WebControlSessionStatusType Failed = new(4, "Failed");

        public WebControlSessionStatusType(short id, string name)
        {
            Id = id;
            Name = name;
        }

        public short Id { get; set; }
        public string Name { get; set; }
    }
}
