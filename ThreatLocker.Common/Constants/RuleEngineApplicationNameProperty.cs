namespace ThreatLockerCommon.Constants
{
    public class RulesEngineActionLogItemProperty
    {
        public static readonly RulesEngineActionLogItemProperty ActionType = new RulesEngineActionLogItemProperty(1, "ActionType");
        public static readonly RulesEngineActionLogItemProperty ApplicationName = new RulesEngineActionLogItemProperty(2, "ApplicationName");
        public static readonly RulesEngineActionLogItemProperty Hash = new RulesEngineActionLogItemProperty(3, "Hash");
        public static readonly RulesEngineActionLogItemProperty CertSha = new RulesEngineActionLogItemProperty(4, "CertSha");
        public static readonly RulesEngineActionLogItemProperty Sha256hash = new RulesEngineActionLogItemProperty(5, "Sha256hash");
        public static readonly RulesEngineActionLogItemProperty Path = new RulesEngineActionLogItemProperty(6, "Path");
        public static readonly RulesEngineActionLogItemProperty ProcessPath = new RulesEngineActionLogItemProperty(7, "ProcessPath");
        public static readonly RulesEngineActionLogItemProperty Notes = new RulesEngineActionLogItemProperty(8, "Notes");
        public static readonly RulesEngineActionLogItemProperty CertSubject = new RulesEngineActionLogItemProperty(9, "CertSubject");
        public static readonly RulesEngineActionLogItemProperty ApplicationFileFullPath = new RulesEngineActionLogItemProperty(10, "ApplicationFileFullPath");
        public static readonly RulesEngineActionLogItemProperty EffectivePath = new RulesEngineActionLogItemProperty(11, "EffectivePath");
        public static readonly RulesEngineActionLogItemProperty EffectiveProcess = new RulesEngineActionLogItemProperty(12, "EffectiveProcess");
        public static readonly RulesEngineActionLogItemProperty PrecisePath = new RulesEngineActionLogItemProperty(13, "PrecisePath");
        public static readonly RulesEngineActionLogItemProperty FileName = new RulesEngineActionLogItemProperty(14, "FileName");
        public static readonly RulesEngineActionLogItemProperty FileNameLength = new RulesEngineActionLogItemProperty(15, "FileNameLength");
        public static readonly RulesEngineActionLogItemProperty CreatedBy = new RulesEngineActionLogItemProperty(16, "CreatedBy");
        public static readonly RulesEngineActionLogItemProperty ParentDirectory = new RulesEngineActionLogItemProperty(17, "ParentDirectory");
        public static readonly RulesEngineActionLogItemProperty RulePath = new RulesEngineActionLogItemProperty(18, "RulePath");
        public static readonly RulesEngineActionLogItemProperty RulePathLength = new RulesEngineActionLogItemProperty(19, "RulePathLength");
        public static readonly RulesEngineActionLogItemProperty Empty = new RulesEngineActionLogItemProperty(21, "Empty");

        public RulesEngineActionLogItemProperty(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly RulesEngineActionLogItemProperty[] AllWindowsProperties =
        {
            ActionType,
            ApplicationFileFullPath,
            ApplicationName,
            CertSubject,
            CreatedBy,
            EffectivePath,
            EffectiveProcess,
            FileName,
            FileNameLength,
            Hash,
            Path,
            PrecisePath,
            ProcessPath,
            Empty
        };

        public static readonly RulesEngineActionLogItemProperty[] AllMacOSProperties =
        {
            ActionType,
            ApplicationFileFullPath,
            CertSubject,
            ParentDirectory,
            Path,
            ProcessPath,
            RulePath,
            RulePathLength,
            Empty
        };

        public static readonly RulesEngineActionLogItemProperty[] AllUnixBasedProperties =
        {
            ActionType,
            ApplicationFileFullPath,
            CertSubject,
            ParentDirectory,
            Path,
            ProcessPath,
            RulePath,
            RulePathLength,
            Empty
        };
    }
}
