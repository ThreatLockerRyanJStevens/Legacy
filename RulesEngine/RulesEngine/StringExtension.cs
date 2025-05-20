using RulesEngine.EngineModule_Classes;

namespace RulesEngine
{
    public static class StringExtension
    {
        public static string ReplacePropertiesWithValues(this string source, ActionLogItem ruleObject)
        {
            if (source == null)
            {
                return null;
            }

            string[] propertiesToReplace = PropertiesHelper.GetPropertiesToReplace(source);

            if (propertiesToReplace == null)
            {
                return source;
            }

            foreach (string property in propertiesToReplace)
            {
                string propertyValue = ConditionBuilder.GetPropertyValue(property, ruleObject)?.ToString() ?? string.Empty;

                if (!string.IsNullOrEmpty(propertyValue))
                {
                    source = source.Replace("[" + property + "]", propertyValue);
                }
            }
            
            return source;
        }
    }
}