namespace ThreatLocker.Shared.Constants
{
    public class WebControlPolicyStatusType
    {
        public static readonly WebControlPolicyStatusType Active = new(1, "Active");
        public static readonly WebControlPolicyStatusType Deleted = new(2, "Deleted");

        public WebControlPolicyStatusType(short id, string name)
        {
            Id = id;
            Name = name;
        }

        public short Id { get; set; }
        public string Name { get; set; }
    }
}
