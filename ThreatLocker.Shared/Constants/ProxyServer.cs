using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class ProxyServer
    {
        public static readonly string Http = "http://";
        public static readonly string Https = "https://";

        public static readonly string[] All =
        {
            Http,
            Https
        };

        public static string Find(string name)
        {
            return All.FirstOrDefault(x => x == name) ?? string.Empty;
        }

        public static string FindStartsWith(string name)
        {
            return All.FirstOrDefault(x => name.StartsWith(x)) ?? string.Empty;
        }

        public static bool IsValid(string name)
        {
            return All.Any(x => name.StartsWith(x));
        }
    }
}
