using RulesEngine.EngineModule_Classes;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace RulesEngine
{
    public class ConditionBuilder
    {
        public static bool EvaluateCondition(EngineModule engineModule, RuleCondition[] ruleConditions)
        {
            // This takes care of all ANDs.
            bool matched = ruleConditions.Where(x => !string.IsNullOrWhiteSpace(x.PropertyName) && !string.IsNullOrWhiteSpace(x.OperationName))
                .All(x => ResolveOperation(x, engineModule.RuleObject));

            return matched;
        }

        public static bool ResolveOperation(RuleCondition ruleCondition, ActionLogItem item)
        {
            int intPropertyValue;
            string strPropertyValue;

            switch (ruleCondition.OperationId)
            {
                case (int)RuleOperation.Contains:
                    strPropertyValue = GetPropertyValue(ruleCondition.PropertyName, item)?.ToString() ?? "";

                    if (ruleCondition.IsNegationRule)
                    {
                        return !strPropertyValue.Contains(ruleCondition.Value);
                    }
                    else
                    {
                        return strPropertyValue.Contains(ruleCondition.Value);
                    }
                case (int)RuleOperation.StartsWith:
                    strPropertyValue = GetPropertyValue(ruleCondition.PropertyName, item)?.ToString() ?? "";

                    if (ruleCondition.IsNegationRule)
                    {
                        return !strPropertyValue.StartsWith(ruleCondition.Value);
                    }
                    else
                    {
                        return strPropertyValue.StartsWith(ruleCondition.Value);
                    }
                case (int)RuleOperation.EndsWith:
                    strPropertyValue = GetPropertyValue(ruleCondition.PropertyName, item)?.ToString() ?? "";

                    if (ruleCondition.IsNegationRule)
                    {
                        return !strPropertyValue.EndsWith(ruleCondition.Value);
                    }
                    else
                    {
                        return strPropertyValue.EndsWith(ruleCondition.Value);
                    }
                case (int)RuleOperation.RegexIsMatch:
                    strPropertyValue = GetPropertyValue(ruleCondition.PropertyName, item)?.ToString() ?? "";

                    if (ruleCondition.IsNegationRule)
                    {
                        return !Regex.IsMatch(strPropertyValue, ruleCondition.Value);
                    }
                    else
                    {
                        return Regex.IsMatch(strPropertyValue, ruleCondition.Value);
                    }
                case (int)RuleOperation.Equal:
                    if (PropertyIsString())
                    {
                        strPropertyValue = GetPropertyValue(ruleCondition.PropertyName, item)?.ToString() ?? "";

                        if (ruleCondition.IsNegationRule)
                        {
                            return strPropertyValue != ruleCondition.Value;
                        }
                        else
                        {
                            return strPropertyValue == ruleCondition.Value;
                        }
                    }
                    else if (PropertyIsInt())
                    {
                        intPropertyValue = Convert.ToInt32(GetPropertyValue(ruleCondition.PropertyName, item));

                        if (ruleCondition.IsNegationRule)
                        {
                            return intPropertyValue != Convert.ToInt32(ruleCondition.Value);
                        }
                        else
                        {
                            return intPropertyValue == Convert.ToInt32(ruleCondition.Value);
                        }
                    }
                    else
                    {
                        return false;
                    }
                case (int)RuleOperation.LessThan:
                    if (PropertyIsInt())
                    {
                        intPropertyValue = Convert.ToInt32(GetPropertyValue(ruleCondition.PropertyName, item));

                        if (ruleCondition.IsNegationRule)
                        {
                            return !(intPropertyValue < Convert.ToInt32(ruleCondition.Value));
                        }
                        else
                        {
                            return intPropertyValue < Convert.ToInt32(ruleCondition.Value);
                        }
                    }
                    else
                    {
                        return false;
                    }
                case (int)RuleOperation.LessThanOrEqual:
                    if (PropertyIsInt())
                    {
                        intPropertyValue = Convert.ToInt32(GetPropertyValue(ruleCondition.PropertyName, item));

                        if (ruleCondition.IsNegationRule)
                        {
                            return !(intPropertyValue <= Convert.ToInt32(ruleCondition.Value));
                        }
                        else
                        {
                            return intPropertyValue <= Convert.ToInt32(ruleCondition.Value);
                        }
                    }
                    else
                    {
                        return false;
                    }
                case (int)RuleOperation.GreaterThan:
                    if (PropertyIsInt())
                    {
                        intPropertyValue = Convert.ToInt32(GetPropertyValue(ruleCondition.PropertyName, item));

                        if (ruleCondition.IsNegationRule)
                        {
                            return !(intPropertyValue > Convert.ToInt32(ruleCondition.Value));
                        }
                        else
                        {
                            return intPropertyValue > Convert.ToInt32(ruleCondition.Value);
                        }
                    }
                    else
                    {
                        return false;
                    }
                case (int)RuleOperation.GreaterThanOrEqual:
                    if (PropertyIsInt())
                    {
                        intPropertyValue = Convert.ToInt32(GetPropertyValue(ruleCondition.PropertyName, item));

                        if (ruleCondition.IsNegationRule)
                        {
                            return !(intPropertyValue >= Convert.ToInt32(ruleCondition.Value));
                        }
                        else
                        {
                            return intPropertyValue >= Convert.ToInt32(ruleCondition.Value);
                        }
                    }
                    else
                    {
                        return false;
                    }
                default:
                    return false;
            }

            bool PropertyIsString()
            {
                return ruleCondition.PropertyName == nameof(item.ActionType)
                || ruleCondition.PropertyName == nameof(item.ApplicationName)
                || ruleCondition.PropertyName == nameof(item.Hash)
                || ruleCondition.PropertyName == nameof(item.CertSha)
                || ruleCondition.PropertyName == nameof(item.Sha256hash)
                || ruleCondition.PropertyName == nameof(item.Notes)
                || ruleCondition.PropertyName == nameof(item.CertSubject)
                || ruleCondition.PropertyName == nameof(item.Path)
                || ruleCondition.PropertyName == nameof(item.ProcessPath)
                || ruleCondition.PropertyName == nameof(item.ApplicationFileFullPath)
                || ruleCondition.PropertyName == nameof(item.Empty)
                || ruleCondition.PropertyName == nameof(item.EffectivePath)
                || ruleCondition.PropertyName == nameof(item.EffectiveProcess)
                || ruleCondition.PropertyName == nameof(item.Hostname)
                || ruleCondition.PropertyName == nameof(item.PrecisePath)
                || ruleCondition.PropertyName == nameof(item.FileName)
                || ruleCondition.PropertyName == nameof(item.CreatedBy)
                || ruleCondition.PropertyName == nameof(item.ParentDirectory)
                || ruleCondition.PropertyName == nameof(item.RulePath);
            }

            bool PropertyIsInt()
            {
                return ruleCondition.PropertyName == nameof(item.FileNameLength)
                || ruleCondition.PropertyName == nameof(item.RulePathLength);
            }
        }

        public static object GetPropertyValue(string propertyName, ActionLogItem item)
        {
            switch (propertyName)
            {
                case nameof(ActionLogItem.ActionType):
                    return item.ActionType;
                case nameof(ActionLogItem.ApplicationName):
                    return item.ApplicationName;
                case nameof(ActionLogItem.Hash):
                    return item.Hash;
                case nameof(ActionLogItem.CertSha):
                    return item.CertSha;
                case nameof(ActionLogItem.Sha256hash):
                    return item.Sha256hash;
                case nameof(ActionLogItem.Notes):
                    return item.Notes;
                case nameof(ActionLogItem.CertSubject):
                    return item.CertSubject;
                case nameof(ActionLogItem.Path):
                    return item.Path;
                case nameof(ActionLogItem.ProcessPath):
                    return item.ProcessPath;
                case nameof(ActionLogItem.ApplicationFileFullPath):
                    return item.ApplicationFileFullPath;
                case nameof(ActionLogItem.Empty):
                    return item.Empty;
                case nameof(ActionLogItem.ParentDirectory):
                    return item.ParentDirectory;
                case nameof(ActionLogItem.RulePath):
                    return item.RulePath;
                case nameof(ActionLogItem.RulePathLength):
                    return item.RulePathLength;
                case nameof(ActionLogItem.EffectivePath):
                    return item.EffectivePath;
                case nameof(ActionLogItem.EffectiveProcess):
                    return item.EffectiveProcess;
                case nameof(ActionLogItem.Hostname):
                    return item.Hostname;
                case nameof(ActionLogItem.PrecisePath):
                    return item.PrecisePath;
                case nameof(ActionLogItem.FileNameLength):
                    return item.FileNameLength;
                case nameof(ActionLogItem.FileName):
                    return item.FileName;
                case nameof(ActionLogItem.CreatedBy):
                    return item.CreatedBy;
                default:
                    return null;
            }
        }

        public static bool CheckPropertyExists(string propertyName)
        {
            return propertyName == nameof(ActionLogItem.ActionType)
                || propertyName == nameof(ActionLogItem.ApplicationName)
                || propertyName == nameof(ActionLogItem.Hash)
                || propertyName == nameof(ActionLogItem.CertSha)
                || propertyName == nameof(ActionLogItem.Sha256hash)
                || propertyName == nameof(ActionLogItem.Notes)
                || propertyName == nameof(ActionLogItem.CertSubject)
                || propertyName == nameof(ActionLogItem.Path)
                || propertyName == nameof(ActionLogItem.ProcessPath)
                || propertyName == nameof(ActionLogItem.ApplicationFileFullPath)
                || propertyName == nameof(ActionLogItem.Empty)
                || propertyName == nameof(ActionLogItem.ParentDirectory)
                || propertyName == nameof(ActionLogItem.RulePath)
                || propertyName == nameof(ActionLogItem.RulePathLength)
                || propertyName == nameof(ActionLogItem.EffectivePath)
                || propertyName == nameof(ActionLogItem.EffectiveProcess)
                || propertyName == nameof(ActionLogItem.Hostname)
                || propertyName == nameof(ActionLogItem.PrecisePath)
                || propertyName == nameof(ActionLogItem.FileNameLength)
                || propertyName == nameof(ActionLogItem.FileName)
                || propertyName == nameof(ActionLogItem.CreatedBy);
        }
    }
}
