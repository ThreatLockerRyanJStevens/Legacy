namespace ThreatLockerCommon.Models
{
    public class ClientProvisionData
    {
        // add all the fields from client provision
        public Organization Organization { get; set; }
        public Contact Contact { get; set; }
        public ClientProvisionGroup Group { get; set; }
    }
}
