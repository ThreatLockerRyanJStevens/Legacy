using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Framework.Extensions
{
    public static class ByteExtension
    {
        public static Byte[] ToSafeByteArray(this object value)
        {
            try
            {
                if (value != null)
                {
                    return (byte[])value;
                }

                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static string ByteToBase64String(this byte[] input)
        {
            return Convert.ToBase64String(input, 0, input.Length);
        }
    }
}
