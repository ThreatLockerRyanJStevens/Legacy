using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class CMPolicySet
    {
        public List<CMPolicy> CMPolicies { get; set; } = new List<CMPolicy>();
        public List<CMConfiguration> CMConfigurations { get; set; } = new List<CMConfiguration>();
        public List<CMEventLogValue> CMEventLogValues { get; set; } = new List<CMEventLogValue>();
    }

    public class CMPolicy
    {
        public Guid CMPolicyId { get; set; }
        public string PolicyName { get; set; }
        public int Status { get; set; }
        public int CMConfigurationId { get; set; }
        public int CMConfigAgentId { get; set; }
        public string CMConfigurationName { get; set; } 
        public int OrderBy { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<CMConfigurationAttribute> CMAttributes { get; set; } = new List<CMConfigurationAttribute>();  
    }

    public class CMConfigurationAttribute
    {
        public Guid CMPolicyId { get; set; }
        public int CMConfigurationId { get; set; }
        public int CMConfigurationAttributeId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Data { get; set; }
        public string DefaultValue { get; set; }        
        public string AttributeName { get; set; }
        public List<CMRegistryValue> CMRegistryValues { get; set; } = new List<CMRegistryValue>();
        public List<CMCommandValue> CMCommandValues { get; set; } = new List<CMCommandValue>();
    }

    public class CMRegistryValue
    {
        public Guid CMPolicyId { get; set; }
        public int CMConfigurationId { get; set; }
        public int CMConfigurationAttributeId { get; set; }
        public string Path { get; set; }
        public string Type { get; set; }
        public string ValueName { get; set; }
        public string Value { get; set; }
        public string DefaultValue { get; set; }
    }

    public class CMCommandValue
    {
        public Guid CMPolicyId { get; set; }
        public int CMConfigurationId { get; set; }
        public int CMConfigurationAttributeId { get; set; }
        public int CMCommandTypeId { get; set; }
        public string Name { get; set; }    
        public string Arguments { get; set; }   
        public int CommandOrder { get; set; }
    }
    public class CMConfiguration
    {
        public int CMConfgAgentId { get; set; }
        public string Name { get; set; }
    }

    public class CMEventLogValue
    {
        public int CMEventLogValueId { get; set; }
        public int EventId { get; set; }
    }

    public class CMUserLogon
    {
        public string LogonID { get; set; }
        public string SID { get; set; }
        public Guid ComputerId { get; set; }
        public string Domain { get; set; }
        public string UserName { get; set; }
        public int EventTypeID { get; set; }
        public DateTime EventDate { get; set; }
        public string IPAddress { get; set; }
        public string AdditionalInfo { get; set; }
    }

    public class CMLAPS
    {
        public string PWord { get; set; }
    }
}
