using System;

namespace PortalApi.DTOs
{
    public class OpsAutoCompleteOption
    {
        public string Label { get; set; } 
        public string Value { get; set; }

        public OpsAutoCompleteOption() { }

        public OpsAutoCompleteOption(string label, string value)
        {
            Label = label;
            Value = value;
        }
    }
}
