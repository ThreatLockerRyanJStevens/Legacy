using Newtonsoft.Json;
using RulesEngine.EngineModule_Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RulesEngine
{
    public class RuleManager
    {
        public static string EvaluateRules(EngineModule engineModule, IEnumerable<Rule> rules, bool logToRoot = false)
        {
            if (engineModule?.RuleObject == null || rules == null)
            {
                return "";
            }

            if (engineModule.Type != ModuleType.ApplicationNameLearning
                    && engineModule.Type != ModuleType.ApplicationFileFullPathLearning
                    && engineModule.Type != ModuleType.ApplicationFileLearning)
            {
                return "";
            }

            string returnValue = "";

            bool isEvaluated = false;
            bool returnsMany = engineModule.Type == ModuleType.ApplicationFileLearning;

            List<ApplicationFile> files = null;

            if (returnsMany)
            {
                files = new List<ApplicationFile>();
            }

            long currentRuleId = 0;

            try
            {
                foreach (Rule rule in rules)
                {
                    currentRuleId = rule.RuleId;

                    if (rule.Conditions?.Length > 0)
                    {
                        if (ConditionBuilder.EvaluateCondition(engineModule, rule.Conditions))
                        {
                            isEvaluated = true;

                            if (returnsMany)
                            {
                                // unmodifiedresult (rule.RuleEvaluation) example: [{"Hash":"[Hash]", "ApplicationName": "[ApplicationName]"}].
                                List<ApplicationFile> tempAppFiles = JsonConvert.DeserializeObject<List<ApplicationFile>>(rule.RuleEvaluation);

                                if (tempAppFiles?.Count > 0)
                                {
                                    tempAppFiles = tempAppFiles.Select(x => { x.Notes = $"({currentRuleId})"; return x; }).ToList();

                                    string[] propertiesToReplace = PropertiesHelper.GetPropertiesToReplace(rule.RuleEvaluation);

                                    string strPropertyValue;

                                    if (propertiesToReplace?.Length > 0)
                                    {
                                        foreach (ApplicationFile tempAppFile in tempAppFiles)
                                        {
                                            foreach (string property in propertiesToReplace)
                                            {
                                                strPropertyValue = ConditionBuilder.GetPropertyValue(property, engineModule.RuleObject)?.ToString() ?? string.Empty;

                                                if (string.IsNullOrEmpty(strPropertyValue))
                                                {
                                                    tempAppFile.ShouldLearn = false;
                                                    break;
                                                }

                                                tempAppFile.FullPath = tempAppFile.FullPath?.Replace($"[{property}]", strPropertyValue);
                                                tempAppFile.ProcessPath = tempAppFile.ProcessPath?.Replace($"[{property}]", strPropertyValue);
                                                tempAppFile.Cert = tempAppFile.Cert?.Replace($"[{property}]", strPropertyValue);
                                                tempAppFile.Hash = tempAppFile.Hash?.Replace($"[{property}]", strPropertyValue);
                                                tempAppFile.ApplicationName = tempAppFile.ApplicationName?.Replace($"[{property}]", strPropertyValue);
                                                tempAppFile.CreatedBy = tempAppFile.CreatedBy?.Replace($"[{property}]", strPropertyValue);
                                            }
                                        }
                                    }

                                    files.AddRange(tempAppFiles.Where(x => x.ShouldLearn));
                                }
                            }
                            else
                            {
                                returnValue = rule.RuleEvaluation;

                                // If ReturnValueMethod is specified, then attempt to call the desired method with the specified parameters.
                                if (!string.IsNullOrEmpty(rule.ReturnValueMethod))
                                {
                                    try
                                    {
                                        string returnValueMethodResult = RunMethod(rule.ReturnValueMethod, engineModule.RuleObject, engineModule.OSType);

                                        if (string.IsNullOrEmpty(rule.RuleEvaluation))
                                        {
                                            returnValue = returnValueMethodResult;
                                        }
                                        else if (!string.IsNullOrEmpty(returnValueMethodResult))
                                        {
                                            returnValue = $"{rule.RuleEvaluation}{returnValueMethodResult}";
                                        }
                                    }
                                    catch
                                    {
                                        returnValue = rule.RuleEvaluation;
                                    }
                                }

                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"Evaluation Error - {ex.Message};\n{engineModule}\nRule Id: {currentRuleId}", logToRoot: logToRoot);

                if (engineModule.Type != ModuleType.ApplicationFileLearning)
                {
                    return string.Empty;
                }
            }

            try
            {
                if (isEvaluated && files?.Count > 0)
                {
                    returnValue = JsonConvert.SerializeObject(files);
                }

                if (engineModule.Type != ModuleType.ApplicationFileLearning)
                {
                    returnValue = returnValue.ReplacePropertiesWithValues(engineModule.RuleObject);
                }

                if (engineModule.Type == ModuleType.ApplicationNameLearning)
                {
                    return ActionLogItem.GetCleanAppName(returnValue, engineModule.OSType);
                }
                else
                {
                    return returnValue;
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"Post Evaluation Error - {ex.Message};\n{engineModule}\nRule Id: {currentRuleId}", logToRoot: logToRoot);
                return string.Empty;
            }
        }

        public static string RunMethod(string returnValueMethodText, ActionLogItem item, int osType)
        {
            // Grab MethodInfo by name.
            string returnEvaluationMethod = returnValueMethodText.Remove(returnValueMethodText.Length - 1, 1);
            int indexOfParameters = returnEvaluationMethod.IndexOf('(');

            string[] parameters = { string.Empty, string.Empty, string.Empty };

            // Get Method parameter (Property Names).
            string[] methodParameterProperties = returnEvaluationMethod.Substring(indexOfParameters + 1).Split(',');

            int i = 0;

            foreach (string parameterProperty in methodParameterProperties)
            {
                if (i > 2)
                {
                    break;
                }

                if (!ConditionBuilder.CheckPropertyExists(parameterProperty.Trim()))
                {
                    // If it is not a property then it is a value to pass into the method.
                    parameters[i] = parameterProperty.Trim();
                }
                else
                {
                    parameters[i] = ConditionBuilder.GetPropertyValue(parameterProperty.Trim(), item)?.ToString().Trim() ?? string.Empty;
                }

                i++;
            }

            string methodName = returnEvaluationMethod.Substring(0, indexOfParameters);

            if (osType == OperatingSystemType.macOS.Id)
            {
                switch (methodName)
                {
                    // ApplicationName Methods.
                    case "GetVendorFromCertMac":
						return ActionLogItem.GetVendorFromCertMac(parameters[0]);
					case "GetNextFolderMac":
                        return ActionLogItem.GetNextFolderMac(parameters[0], parameters[1]);
                    case "GetNextFolderByFolderMac":
                        return ActionLogItem.GetNextFolderByFolderMac(parameters[0], parameters[1]);
                    case "GetSubDirectoryReplaceApp":
                        return ActionLogItem.GetSubDirectoryReplaceApp(parameters[0], parameters[1]);
                    case "GetLastDirectory":
                        return ActionLogItem.GetLastDirectory(parameters[0]);
                    case "GetSubDirectory":
                        return ActionLogItem.GetSubDirectory(parameters[0], parameters[1]);
                    case "GetParentDirectoryName":
                        return ActionLogItem.GetParentDirectoryName(parameters[0]);
                    // FileFullPath Methods.
                    case "GetFileFullPathBySubDirectory":
                        return ActionLogItem.GetFileFullPathBySubDirectory(parameters[0], parameters[1]);
                    case "GetFileFullPathByParentDirectory":
                        return ActionLogItem.GetFileFullPathByParentDirectory(parameters[0], parameters[1]);
                    case "MacAddWildCardAfterXDirectory":
                        return ActionLogItem.MacAddWildCardAfterXDirectory(parameters[0], parameters[1], parameters[2]);
                    case "GetFileFullPathBySubDirectoryReplace":
                        return ActionLogItem.GetFileFullPathBySubDirectoryReplace(parameters[0], parameters[1], parameters[2]);
                    default:
                        return string.Empty;
                }
            }
            else if (osType == OperatingSystemType.Linux.Id)
            {
                switch (methodName)
                {
                    // ApplicationName Methods.
                    case "GetNextFolderUnix":
                        return ActionLogItem.GetNextFolderUnix(parameters[0], parameters[1]);
                    case "GetNextFolderByFolderUnix":
                        return ActionLogItem.GetNextFolderByFolderUnix(parameters[0], parameters[1]);
                    case "GetLastDirectory":
                        return ActionLogItem.GetLastDirectory(parameters[0]);
                    case "GetSubDirectory":
                        return ActionLogItem.GetSubDirectory(parameters[0], parameters[1]);
                    case "GetParentDirectoryName":
                        return ActionLogItem.GetParentDirectoryName(parameters[0]);
                    // FileFullPath Methods.
                    case "GetFileFullPathBySubDirectory":
                        return ActionLogItem.GetFileFullPathBySubDirectory(parameters[0], parameters[1]);
                    case "GetFileFullPathByParentDirectory":
                        return ActionLogItem.GetFileFullPathByParentDirectory(parameters[0], parameters[1]);
                    case "AddWildCardAfterNDirectory":
                        return ActionLogItem.AddWildCardAfterNDirectory(parameters[0], parameters[1], parameters[2]);
                    case "GetFileFullPathBySubDirectoryReplace":
                        return ActionLogItem.GetFileFullPathBySubDirectoryReplace(parameters[0], parameters[1], parameters[2]);
                    default:
                        return string.Empty;
                }
            }
            else
            {
                switch (methodName)
                {
                    // ApplicationName Methods.
                    case "GetNextFolder":
                        return ActionLogItem.GetNextFolder(parameters[0], parameters[1]);
                    case "GetVendorFromCert":
                        return ActionLogItem.GetVendorFromCert(parameters[0]);
                    case "GetWindowsAppName":
                        return ActionLogItem.GetWindowsAppName(parameters[0], parameters[1]);
                    case "CalculateByNthIndex":
                        return ActionLogItem.CalculateByNthIndex(parameters[0]);
                    case "GetNextFolderByFolder":
                        return ActionLogItem.GetNextFolderByFolder(parameters[0], parameters[1]);
                    // FileFullPath Methods.
                    case "AddWildCardAfterXDirectory":
                        return ActionLogItem.AddWildCardAfterXDirectory(parameters[0], parameters[1], parameters[2]);
                    case "GetFileName":
                        return ActionLogItem.GetFileName(parameters[0]);
                    case "GetByUnderscoreIndex":
                        return ActionLogItem.GetByUnderscoreIndex(parameters[0]);
                    case "AddSafeRegexToPath":
                        return ActionLogItem.AddSafeRegexToPath(parameters[0], parameters[1]);
                    case "GetLastFolderByPath":
                        return ActionLogItem.GetLastFolderByPath(parameters[0], parameters[1]);
                    case "GetLastFolderByPathReplace":
                        return ActionLogItem.GetLastFolderByPathReplace(parameters[0], parameters[1], parameters[2]);
                    case "GetLastFolderByProcessPathReplace":
                        return ActionLogItem.GetLastFolderByProcessPathReplace(parameters[0], parameters[1], parameters[2]);
                    default:
                        return string.Empty;
                }
            }
        }
    }
}
