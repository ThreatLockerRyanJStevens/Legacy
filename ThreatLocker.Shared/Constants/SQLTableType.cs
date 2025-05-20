namespace ThreatLocker.Shared.Constants
{
    /// <summary>
    /// Used within a Sql parameter to pass values into stored procedures
    /// </summary>
    public class SQLTableType
    {
        public static string ApplicationFileProcessQueueList => "dbo.ApplicationFileProcessQueueList";
        public static string BigIntList => "dbo.BigIntList";
        public static string HelpDeskCommentList => "dbo.HelpDeskCommentListv2";
        public static string IdValueList => "dbo.IdValueList";
        public static string IdPairList => "dbo.IdPairList";
        public static string IntList => "dbo.IntList";
        public static string MaintenanceModeList => "dbo.MaintenanceModeList";
        public static string String128List => "dbo.String128List";
        public static string String2000List => "dbo.String2000List";
        public static string String2048List => "dbo.String2048List";
        public static string String300List => "dbo.String300List";
        public static string NVarChar300List => "dbo.NVarChar300List";
        public static string TWPolicyAttributeList => "dbo.TWPolicyAttributeListV2"; // Using V2 type until original can be safetly dropped and recreated
        public static string CMPolicyAttributeList => "dbo.CMPolicyAttributeList";
        public static string UniqueIdentifierList => "dbo.UniqueIdentifierList";
    }
}
