using System;
using System.Linq;
using ThreatLocker.Framework.Extensions;

namespace ThreatLocker.Framework.Utils
{
    public class StringUtil
    {
        public static string GenerateRandomString(int length, bool includeSymbols = false)
        {
            string chars = $"abcdefghijklmnopqrstuvwxyz0123456789{(includeSymbols ? ".#$*@" : "")}";

            var random = new Random();
            var randomString = new string(Enumerable.Repeat(chars, length)
                                                    .Select(s => s[random.Next(s.Length)]).ToArray());
            return randomString;
        }

        public static void GetAgentVersion(string version, out int versionMajor, out int versionMinor, out int versionPatch, int osType = 1)
        {
            versionMajor = 0;
            versionMinor = 0;
            versionPatch = 0;
            string agentVersion = string.Empty;

            if (string.IsNullOrEmpty(version))
            {
                return;
            }

            switch (osType)
            {
                case 1:
                case 5:
                    agentVersion = version.Contains('/') ? version.Substring(0, version.IndexOf('/')) : version;
                    break;
                case 2:
                    if (version.StartsWith("[MAC] "))
                    {
                        agentVersion = version.Substring(6);
                    }
                    break;
                case 3:
                    if (version.StartsWith("[LINUX] "))
                    {
                        agentVersion = version.Substring(6);
                    }
                    break;
                default:
                    return;
            }

            if (agentVersion.Contains('.'))
            {
                versionMajor = agentVersion.Split('.')[0].ToSafeInt();
                versionMinor = agentVersion.Split('.')[1].ToSafeInt();

                if (agentVersion.Count(v => v == '.') > 2)
                {
                    versionPatch = agentVersion.Split('.')[2].ToSafeInt();
                }
            }
        }
    }
}
