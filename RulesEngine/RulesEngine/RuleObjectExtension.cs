using System;
using System.IO;
using RulesEngine.EngineModule_Classes;

namespace RulesEngine
{
    public static class RuleObjectExtension
    {
        public static ActionLogItem PrepareItemForProcessing(this ActionLogItem source, ModuleType moduleType, int osType)
        {
            try
            {
                if (source == null)
                {
                    return null;
                }

                if (moduleType == ModuleType.ApplicationNameLearning)
                {
                    if (osType == OperatingSystemType.Windows.Id || osType == OperatingSystemType.WindowsXP.Id)
                    {
                        source.CertSubject = source.CertSubject?.ToLower() ?? "";
                        source.Path = source.Path?.ToLower() ?? "";
                        source.ProcessPath = source.ProcessPath?.ToLower() ?? "";
                        source.ApplicationName = source.ApplicationName?.ToLower() ?? "";
                        source.EffectivePath = source.Path;
                        source.PrecisePath = source.Path;
                        source.EffectiveProcess = source.ProcessPath;
                        source.FileName = string.Empty;

                        try
                        {
                            source.FileName = Path.GetFileName(source.Path);
                            source.FileNameLength = source.FileName.Length;
                        }
                        catch
                        {

                        }

                        if (!string.IsNullOrEmpty(source.EffectivePath) && source.EffectivePath.Substring(1).StartsWith(":"))
                        {
                            source.EffectivePath = source.EffectivePath.Substring(1);

                            if (source.Path.Length > 2)
                            {
                                source.PrecisePath = source.EffectivePath.Substring(1);
                            }
                        }

                        if ((!string.IsNullOrEmpty(source.EffectiveProcess))
                            && source.EffectiveProcess.Substring(1).StartsWith(":"))
                        {
                            source.EffectiveProcess = source.EffectiveProcess.Substring(1);
                        }
                    }
                    else if (osType == OperatingSystemType.macOS.Id || osType == OperatingSystemType.Linux.Id)
                    {
                        source.ParentDirectory = ActionLogItem.GetParentDirectory(source.Path)?.ToLower();
                        source.RulePath = string.Empty;
                        source.Path = source.Path?.ToLower() ?? "";
                        source.ApplicationName = source.ApplicationName?.ToLower() ?? "";

                        if (!string.IsNullOrEmpty(source.Path))
                        {
                            source.RulePath = source.Path.Remove(0, source.ParentDirectory.Length);
                            source.RulePathLength = source.RulePath.Length;
                        }
                    }
                }
                else if (moduleType == ModuleType.ApplicationFileFullPathLearning
                    || moduleType == ModuleType.ApplicationFileLearning)
                {
                    if (osType == OperatingSystemType.Windows.Id || osType == OperatingSystemType.WindowsXP.Id)
                    {
                        source.Path = source.Path?.ToLower() ?? "";
                        source.CertSubject = source.CertSubject?.ToLower() ?? "";
                        source.ProcessPath = source.ProcessPath?.ToLower() ?? "";
                        source.ApplicationName = source.ApplicationName?.ToLower() ?? "";

                        if (string.IsNullOrEmpty(source.ActionType))
                        {
                            source.ActionType = "execute";
                        }

                        source.EffectivePath = source.Path;

                        if (!string.IsNullOrEmpty(source.EffectivePath) && source.EffectivePath.Substring(1).StartsWith(":"))
                        {
                            source.EffectivePath = source.EffectivePath.Substring(1);
                        }

                        source.Notes = string.Empty;

                        if (source.CertSubject.Contains("o="))
                        {
                            source.CertSubject = source.CertSubject.Substring(source.CertSubject.IndexOf("o="));
                        }

                        if (source.CertSubject.Contains("c="))
                        {
                            string country = source.CertSubject.Substring(source.CertSubject.IndexOf("c="));

                            if (country.Contains(","))
                            {
                                country = country.Substring(0, country.IndexOf(","));
                            }

                            source.CertSubject = source.CertSubject.Substring(0, source.CertSubject.IndexOf(country) + country.Length);
                        }

                        if (source.CertSubject == "o=threatlocker inc, l=maitland, s=fl, c=us")
                        {
                            source.CertSubject = string.Empty;
                        }
                    }
                    else if (osType == OperatingSystemType.macOS.Id || osType == OperatingSystemType.Linux.Id)
                    {
                        source.Path = source.Path?.ToLower() ?? "";
                        source.CertSubject = source.CertSubject?.ToLower() ?? "";
                        source.ProcessPath = source.ProcessPath?.ToLower() ?? "";
                        source.ApplicationName = source.ApplicationName?.ToLower() ?? "";

                        if (string.IsNullOrEmpty(source.ActionType))
                        {
                            source.ActionType = "execute";
                        }

                        source.ParentDirectory = ActionLogItem.GetParentDirectory(source.Path)?.ToLower();
                        source.RulePath = string.Empty;
                        source.Notes = string.Empty;

                        if (!string.IsNullOrEmpty(source.Path))
                        {
                            source.RulePath = source.Path.Remove(0, source.ParentDirectory.Length);
                            source.RulePathLength = source.RulePath.Length;
                        }
                    }
                }

                return source;
            }
            catch (Exception)
            {
                return source;
            }
        }
    }
}
