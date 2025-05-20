using System;
using System.Runtime.Serialization;

namespace ThreatLocker.Framework.DbLogger
{
#if NET6_0_OR_GREATER

    [Serializable]
    public class SqlServerException : Exception
    {
        public SqlServerException()
        {
        }

        public SqlServerException(string message) : base(message)
        {
        }

        public SqlServerException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SqlServerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
#endif
}
