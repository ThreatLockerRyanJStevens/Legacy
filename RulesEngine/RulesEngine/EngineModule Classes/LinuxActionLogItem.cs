using System;

namespace RulesEngine.EngineModule_Classes
{
    public partial class ActionLogItem
    {
        public static string GetNextFolderByFolderUnix(string path, string fullPath)
        {
            string folder = fullPath.Substring(0, fullPath.IndexOf(path) + path.Length);
            return GetNextFolderUnix(folder, fullPath);
        }

        public static string GetNextFolderUnix(string value, string fullPath)
        {
            string secondPart = fullPath.Substring(value.Length);
            string ret = "";

            try
            {
                if (secondPart.Contains("/"))
                {
                    ret = secondPart.Substring(0, secondPart.IndexOf("/"));
                }
                else
                {
                    ret = secondPart;
                }
            }
            catch
            {
                ret = secondPart;
            }

            return ret;
        }

        public static string AddWildCardAfterNDirectory(string path, string x, string suffix)
        {
            string ret = path.Substring(0, GetNthIndex(path, '/', Convert.ToInt32(x))) + "/*";

            if (!string.IsNullOrEmpty(suffix))
            {
                return ret + suffix;
            }
            else
            {
                return ret;
            }
        }
    }
}
