using System.Collections.Generic;

namespace ThreatLocker.Framework.DbLogger
{
#if NET6_0_OR_GREATER

    public class DbLogScopeInfo
    {
        public string Text { get; set; }
        public Dictionary<string, object> Properties { get; set; }
    }
#endif
}