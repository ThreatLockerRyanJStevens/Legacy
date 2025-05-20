using System;
using System.Runtime.Serialization;

namespace ThreatLocker.Framework.DbLogger
{
#if NET6_0_OR_GREATER

    [Serializable]
    public class ForbiddenException : Exception
    {
        public ForbiddenException()
        {
        }

        public ForbiddenException(string message) : base(message)
        {
        }

        public ForbiddenException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ForbiddenException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
#endif
}
