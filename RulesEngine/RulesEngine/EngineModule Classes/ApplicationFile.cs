using Newtonsoft.Json;

namespace RulesEngine.EngineModule_Classes
{
    public class ApplicationFile
    {
        public string FullPath { get; set; }
        public string ProcessPath { get; set; }
        public string Cert { get; set; }
        public string Hash { get; set; }
        public string ApplicationName { get; set; }
        public string Notes { get; set; }
        public string CreatedBy { get; set; }

        [JsonIgnore]
        public bool ShouldLearn { get; set; } = true;
    }
}
