using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace RulesEngine.EngineModule_Classes
{
    public partial class ActionLogItem
    {
        public string EffectivePath { get; set; }
        public string EffectiveProcess { get; set; }
        public string Hostname { get; set; }
        public string PrecisePath { get; set; }
        public int FileNameLength { get; set; }
        public string FileName { get; set; }
        public string CreatedBy { get; set; }

        // Application Name Methods.
        public static string GetWindowsAppName(string path, string effectivePath)
        {
            string folderName = GetNextFolder(path, effectivePath);

            if (folderName.Contains("_"))
            {
                return "Windows App " + folderName.Substring(0, folderName.IndexOf("_")).Replace(".", " ");
            }
            else
            {
                return "Windows App " + folderName;
            }
        }

        public static string GetNextFolderByFolder(string path, string effectivePath)
        {
            string folder = effectivePath.Substring(0, effectivePath.IndexOf(path) + path.Length);
            return GetNextFolder(folder, effectivePath);
        }

        public static string GetNextFolder(string value, string effectivePath)
        {
            string secondPart = effectivePath.Substring(value.Length);
            string ret = "";

            try
            {
                if (secondPart.Contains("\\"))
                {
                    ret = secondPart.Substring(0, secondPart.IndexOf("\\"));
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

        public static string GetVendorFromCert(string cert)
        {
            string vendor = cert.ToLower().Replace("o=", "|").Split('|')[1];

            if (vendor.StartsWith("\\\""))
            {
                vendor = vendor.Split('\"')[1].Replace("\"", "").Replace("\\", "");
            }
            else
            {
                vendor = vendor.Split(',')[0];
            }

            vendor = Regex.Replace(vendor, @"\b(\w)", x => x.Value.ToUpper());
            return vendor.Replace("\"", "").Trim();
        }

        public static string CalculateByNthIndex(string effectivePath)
        {
            int start = GetNthIndex(effectivePath, '\\', 3) + 1;
            int end = GetNthIndex(effectivePath, '\\', 4);
            return effectivePath.Substring(start, end - start);
        }

        // ApplicationFile FullPath Methods.
        public static string AddWildCardAfterXDirectory(string path, string x, string suffix)
        {
            string ret = path.Substring(0, GetNthIndex(path, '\\', Convert.ToInt32(x))) + "\\*";

            if (!string.IsNullOrEmpty(suffix))
            {
                return ret + suffix;
            }
            else
            {
                return ret;
            }
        }

        public static string GetByUnderscoreIndex(string path)
        {
            return path.Substring(0, path.IndexOf("_")) + "*";
        }

        public static string AddSafeRegexToPath(string path, string appliedPath)
        {
            string tFolder = path.Substring(path.IndexOf(appliedPath) + appliedPath.Length);
            tFolder = tFolder.Substring(0, tFolder.IndexOf("\\"));
            return Regex.Escape(tFolder);
        }

        public static string GetLastFolderByPath(string suffix, string path)
        {
            string folder = System.IO.Path.GetDirectoryName(path);
            string ret = folder.Substring(0, folder.LastIndexOf("\\") + 1);

            if (!string.IsNullOrEmpty(suffix))
            {
                return ret + suffix;
            }
            else
            {
                return ret;
            }
        }

        public static string GetLastFolderByPathReplace(string suffix, string replacementDirectory, string path)
        {
            string filePathBySubDirectory = GetLastFolderByPath(suffix, path);

            if (!string.IsNullOrEmpty(filePathBySubDirectory))
            {
                string directoryToReplace = string.Empty;

                int startIndex = filePathBySubDirectory.IndexOf(replacementDirectory);

                if (startIndex == -1)
                {
                    return string.Empty;
                }

                replacementDirectory = filePathBySubDirectory.Substring(0, startIndex + replacementDirectory.Length);

                if (replacementDirectory.Contains('\\'))
                {
                    directoryToReplace = GetNextFolderByFolder(replacementDirectory, filePathBySubDirectory);
                }

                if (!string.IsNullOrEmpty(directoryToReplace))
                {
                    if (directoryToReplace.Equals("*"))
                    {
                        return filePathBySubDirectory;
                    }
                    else if (filePathBySubDirectory.ToLower().Contains($"\\{directoryToReplace}\\"))
                    {
                        int index = filePathBySubDirectory.IndexOf($"\\{directoryToReplace}\\");

                        return replacementDirectory.TrimEnd('\\')
                            + filePathBySubDirectory.Substring(index, directoryToReplace.Length + 2).Replace($"\\{directoryToReplace}\\", "\\*\\")
                            + filePathBySubDirectory.Substring(index + directoryToReplace.Length + 2);
                        //return ReplaceTextWithWildCard(filePathBySubDirectory, directoryToReplace, '/');
                    }
                }
            }

            return "";
        }

        public static string GetLastFolderByProcessPathReplace(string suffix, string replacementDirectory, string processPath)
        {
            return GetLastFolderByPathReplace(suffix, replacementDirectory, processPath);
        }

        public static string GetFileName(string path)
        {
            return System.IO.Path.GetFileName(path.ToLower());
        }

        //"\\\\se software\\"
        public static int GetNthIndex(string s, char t, int n)
        {
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == t)
                {
                    count++;

                    if (count == n)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }
    }
}
