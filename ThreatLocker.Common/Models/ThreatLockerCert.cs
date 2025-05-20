namespace ThreatLockerCommon.Models
{
    public class ThreatLockerCert
    {
        public string sha;
        public string subject;
        public bool validCert = true;
        // Use the following variable to check certificate validity.
        public bool? isValid; 
    }
}