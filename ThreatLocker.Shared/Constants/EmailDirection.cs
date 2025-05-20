namespace ThreatLocker.Shared.Constants
{
    public class EmailDirection
    {
        public static readonly EmailDirection SendEmail = new EmailDirection(1, "Send Email");
        public static readonly EmailDirection ReceivedEmail = new EmailDirection(2, "Received Email");

        public EmailDirection(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
