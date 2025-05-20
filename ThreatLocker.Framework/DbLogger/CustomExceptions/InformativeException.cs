using System;
using System.Runtime.Serialization;

namespace ThreatLocker.Framework.DbLogger
{
#if NET6_0_OR_GREATER
    [Serializable]
    public class InformativeException : Exception
    {
        public InformativeException()
        {
        }

        public InformativeException(string message) : base(message)
        {
        }

        public InformativeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InformativeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
#endif
}
