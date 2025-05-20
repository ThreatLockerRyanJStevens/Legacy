using System;
using System.Linq;

namespace RulesEngine
{
    public class PropertiesHelper
    {
        public static string[] GetPropertiesToReplace(string returnValue)
        {
            if (returnValue == null)
            {
                return null;
            }

            if (returnValue.Contains("[") && returnValue.Contains("]"))
            {
                return returnValue.Split(new char[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries)?.Where(x => ConditionBuilder.CheckPropertyExists(x))?.ToArray();
            }

            return null;
        }
    }
}
