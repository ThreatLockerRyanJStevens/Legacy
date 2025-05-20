using System.ComponentModel;

namespace ThreatLocker.Shared.Constants.Ops
{
    public enum OpsSQLDataFieldType
    {
        [Description("Auto Complete")]
        AutoComplete = 14,

        [Description("SQL Dropdown")]
        SQLDropdown = 17,

        [Description("SQL MultiSelect")]
        SQLMultiSelect = 19
    }
}
