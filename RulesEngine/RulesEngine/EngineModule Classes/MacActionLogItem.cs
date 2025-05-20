using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace RulesEngine.EngineModule_Classes
{
    public partial class ActionLogItem
    {
        public string ParentDirectory { get; set; }
        public string RulePath { get; set; }
        public int RulePathLength { get; set; }

        public static string GetParentDirectory(string path)
        {
            if (path == null)
            {
                return "";
            }

            string parentDirectory = string.Empty;

            int firstIndex = path.IndexOf('/');

            if (firstIndex == 0)
            {
                int secondIndex = path.IndexOf('/', 1);

                if (secondIndex != -1)
                {
                    return path.Substring(0, secondIndex);
                }
                else
                {
                    return path;
                }
            }

            return parentDirectory;
        }

        public static string GetSubDirectoryReplaceApp(string startingDirectory, string path)
        {
            return GetSubDirectory(startingDirectory, path).Replace(".app", "");
        }

        public static string GetSubDirectory(string startingDirectory, string path)
        {
            int index = path.IndexOf(startingDirectory);

            if (index != -1)
            {
                int total = index + startingDirectory.Length;

                if (path.Length > total)
                {
                    path = path.Remove(0, total);
                    return GetParentDirectory(path).Replace("/", "");
                }
            }

            return "";
        }


		public static string GetVendorFromCertMac(string cert)
		{
			string vendor = cert.ToLower().Replace("o=", "|").Split('|')[1];

			if (vendor.StartsWith("/\""))
			{
				vendor = vendor.Split('\"')[1].Replace("\"", "").Replace("/", "");
			}
			else
			{
				vendor = vendor.Split(',')[0];
			}

			vendor = Regex.Replace(vendor, @"\b(\w)", x => x.Value.ToUpper());
			return vendor.Replace("\"", "").Trim();
		}


		public static string GetNextFolderByFolderMac(string path, string fullPath)
        {
            string folder = fullPath.Substring(0, fullPath.IndexOf(path) + path.Length);
            return GetNextFolderMac(folder, fullPath);
        }

        public static string GetNextFolderMac(string value, string fullPath)
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

        public static string GetParentDirectoryName(string parentDirectory)
        {
            return parentDirectory.Replace("/", "");
        }

        public static string GetLastDirectory(string path)
        {
            if (path == null)
            {
                return "";
            }

            if (path.Contains("/"))
            {
                string[] strings = path.Split('/');
                return strings[strings.Length - 1];
            }
            else
            {
                return "";
            }
        }

        public static string MacAddWildCardAfterXDirectory(string path, string x, string suffix)
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

        public static string GetFileFullPathByParentDirectory(string parentDirectory, string path)
        {
            parentDirectory = parentDirectory.Replace("/", "");
            int index = path.IndexOf(parentDirectory);

            if (index != -1)
            {
                int total = index + parentDirectory.Length;

                if (path.Length > total)
                {
                    path = path.Remove(0, total);
                    return $"/{parentDirectory}/{GetParentDirectory(path).Replace("/", "")}/*";
                }
            }

            return "";
        }

        public static string GetFileFullPathBySubDirectory(string startingDirectory, string path)
        {
            int index = path.IndexOf(startingDirectory);

            if (index != -1)
            {
                int total = index + startingDirectory.Length;

                if (path.Length > total)
                {
                    string followingDirectory = path.Remove(0, total);
                    return path.Substring(0, total) + "/" + GetParentDirectory(followingDirectory).Replace("/", "") + "/*";
                }
            }

            return "";
        }

        public static string GetFileFullPathBySubDirectoryReplace(string startingDirectory, string replacementDirectory, string path)
        {
            string filePathBySubDirectory = GetFileFullPathBySubDirectory(startingDirectory, path);

            if (!string.IsNullOrEmpty(filePathBySubDirectory))
            {
                string directoryToReplace = string.Empty;

                int startIndex = filePathBySubDirectory.IndexOf(replacementDirectory);

                if (startIndex == -1)
                {
                    return string.Empty;
                }

                replacementDirectory = filePathBySubDirectory.Substring(0, startIndex + replacementDirectory.Length);

                if (replacementDirectory.Contains('/'))
                {
                    directoryToReplace = GetNextFolderByFolderMac(replacementDirectory, filePathBySubDirectory);
                }

                if (!string.IsNullOrEmpty(directoryToReplace))
                {
                    if (directoryToReplace.Equals("*"))
                    {
                        return filePathBySubDirectory;
                    } 
                    else if (filePathBySubDirectory.ToLower().Contains($"/{directoryToReplace}/"))
                    {
                        int index = filePathBySubDirectory.IndexOf($"/{directoryToReplace}/");

                        return replacementDirectory.TrimEnd('/')
                            + filePathBySubDirectory.Substring(index, directoryToReplace.Length + 2).Replace($"/{directoryToReplace}/", $"/*/")
                            + filePathBySubDirectory.Substring(index + directoryToReplace.Length + 2);

                        //return ReplaceTextWithWildCard(filePathBySubDirectory, directoryToReplace, '/');
                    }
                }
            }

            return "";
        }
    }
}
