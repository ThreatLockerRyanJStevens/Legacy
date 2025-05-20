namespace ThreatLocker.Shared.Models
{
    public class ServiceNowIntegrationValidation
    {
        public string InstanceUrl { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }
}
