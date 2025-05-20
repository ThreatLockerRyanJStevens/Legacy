namespace ThreatLocker.Shared.Constants.LiveChat
{
    public class LiveChatUserType
    {
        public static readonly LiveChatUserType Customer = new LiveChatUserType("customer");
        public static readonly LiveChatUserType Agent = new LiveChatUserType("agent");

        public LiveChatUserType(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}