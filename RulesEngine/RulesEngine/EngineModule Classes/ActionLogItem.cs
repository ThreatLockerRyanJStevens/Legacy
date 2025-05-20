using System.Linq;

namespace RulesEngine.EngineModule_Classes
{
    public partial class ActionLogItem
    {
        public string ActionType { get; set; } = "";
        public string ApplicationName { get; set; } = "";
        public string Hash { get; set; } = "";
        public string CertSha { get; set; }
        public string Sha256hash { get; set; }
        public string Notes { get; set; }
        public string CertSubject { get; set; }
        public string Path { get; set; }
        public string ProcessPath { get; set; }
        public string ApplicationFileFullPath { get; set; }
        public string Empty { get; set; } = "";

        public static string GetCleanAppName(string appName, int osType)
        {
            if (string.IsNullOrEmpty(appName))
            {
                return "";
            }

            appName = appName.Trim();

            if (appName.StartsWith("$"))
            {
                return appName;
            }
            else if (appName.ToLower() == "package cache")
            {
                return "";
            }
            else
            {
                appName = appName.ToLower().Trim();
                appName = RemoveVersionNumber(appName);
                appName = TrimLegalRegistration(appName);
                appName = RemoveDuplicateWords(appName);

                if (osType  == OperatingSystemType.macOS.Id)
                {
                    if (appName.EndsWith(".app"))
                    {
                        return appName.Substring(0, appName.Length - 4);
                    } 
                    else if (appName.EndsWith(".bundle"))
                    {
                        return appName.Substring(0, appName.Length - 7);
                    }
                }

                return appName;
            }
        }

        public static string TrimLegalRegistration(string appName)
        {
            string ret = "";

            if (appName.EndsWith("inc"))
            {
                ret = appName.Substring(0, appName.Length - 3);
            }
            else if (appName.EndsWith("corp"))
            {
                ret = appName.Substring(0, appName.Length - 4);
            }
            else if (appName.EndsWith("llc"))
            {
                ret = appName.Substring(0, appName.Length - 3);
            }

            // If the app is only legal registration, return the app name, otherwise trim the numbeer from the end. 
            return string.IsNullOrEmpty(ret) ? appName : ret;
        }

        public static string RemoveDuplicateWords(string appName)
        {
            string ret = "";
            var sent = appName.ToLower().Trim().Split(' ').Distinct();

            foreach (string s in sent)
            {
                if (!string.IsNullOrWhiteSpace(s))
                {
                    ret = ret + " " + s.Substring(0, 1).ToUpper() + s.Substring(1);
                }
            }

            return ret.Trim();
        }

        public static string RemoveVersionNumber(string appName)
        {
            char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.' };
            string ret = appName.TrimEnd(digits);

            // If the app is only a number, return the app name, otherwise trim the numbeer from the end. 
            return string.IsNullOrEmpty(ret) ? appName : ret;
        }

        public static string ReplaceTextWithWildCard(string fullPath, string directoryToReplace, char separator)
        {
            if (fullPath == null)
            {
                return string.Empty;
            }

            if (fullPath.ToLower().Contains($"{separator}{directoryToReplace}{separator}"))
            {
                return ReplaceTextWithWildCard(fullPath.Replace($"{separator}{directoryToReplace}{separator}", $"{separator}*{separator}"), directoryToReplace, separator);
            }
            else
            {
                return fullPath;
            }
        }
    }
}
