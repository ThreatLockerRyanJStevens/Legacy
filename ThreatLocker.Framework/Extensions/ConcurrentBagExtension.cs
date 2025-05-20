using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Framework.Extensions
{
    public static class ConcurrentBagExtension
    {
        public static void AddRange<T>(this ConcurrentBag<T> values, IEnumerable<T> range)
        {
            foreach (T newValue in range)
            {
                values.Add(newValue);
            }
        }
    }
}
