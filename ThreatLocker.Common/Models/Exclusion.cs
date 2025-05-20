namespace ThreatLockerCommon.Models
{
    public class Exclusion
    {
        public string ProcessPath { get; set; }
        public int Type { get; set; }
        public string Username { get; set; }
        public string FilePathPattern { get; set; }
    }
}
