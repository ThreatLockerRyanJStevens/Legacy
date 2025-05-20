namespace ThreatLocker.Shared.Constants.LiveChat
{
    public class LiveChatRecipientType
    {
        public static readonly LiveChatRecipientType All = new LiveChatRecipientType("all");
        public static readonly LiveChatRecipientType Agents = new LiveChatRecipientType("agents");

        public LiveChatRecipientType(string name)
        {
            Name = name;
        }

        public string Name {  get; set; }
    }
}
