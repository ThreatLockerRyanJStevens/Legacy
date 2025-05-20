using System;
using System.Collections.Generic;
using ThreatLockerCommon.Constants;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Linq;

namespace ThreatLockerCommon.Models
{
    [Serializable]
    public class NetworkAccessRule
    {
        public Guid NetworkAccessRuleId { get; set; }
        public Guid NetworkAccessPolicyId { get; set; }
        public int Type { get; set; } //1 = source, 2 = destination NOTE: (destination = server) (source = client)
        public List<NetworkAccessRuleLocation> Locations { get; set; } = new List<NetworkAccessRuleLocation>();
        public List<PortRange> PortRanges { get; set; } = new List<PortRange>();
    }

    [Serializable]
    public class PortRange
    {
        public int MinPort { get; set; }
        public int MaxPort { get; set; }
        public override string ToString()
        {
            return $"{MinPort} - {MaxPort}";
        }
    }

    [Serializable]
    public class NetworkAccessRuleLocation
    {
        public int Type { get; set; }   //Use NetworkAccessRuleLocationType
        public string Value { get; set; }
        public Guid? Id { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public string KeyValue
        {
            get
            {
                if (Type == NetworkAccessRuleLocationType.Tag.Id || Type == NetworkAccessRuleLocationType.Object.Id)
                {
                    return Id.ToSafeString();
                }
                else
                {
                    return Value;
                }
            }
        }       

        [JsonIgnore]
        [IgnoreDataMember]
        public string DisplayType => Type > 0 ? NetworkAccessRuleLocationType.Find(Type).Name : string.Empty;

        [JsonIgnore]
        [IgnoreDataMember]
        public string DisplayValue
        {
            get
            {
                if (Array.Exists(NetworkAccessRuleLocationType.IPLocations, x => x.Id == Type))
                {
                    return Value.Substring(Value.IndexOf(":") + 1);
                }
                else if (Type == NetworkAccessRuleLocationType.Tag.Id || Type == NetworkAccessRuleLocationType.Object.Id)
                {
                    return Name;
                }
                else
                {
                    return Value;
                }
            }
        }
    }

    [Serializable]
    public class NetworkAccessRuleDTO
    {
        public NetworkAccessRuleDTO() { }
        public NetworkAccessRuleDTO(NetworkAccessRule rule)
        {
            Type = rule.Type;
            Locations = rule.Locations.Select(x => new NetworkAccessRuleLocationDTO(x)).ToList();
            PortRanges = rule.PortRanges;
        }

        public int Type { get; set; } //1 = source, 2 = destination NOTE: (destination = server) (source = client)
        public List<NetworkAccessRuleLocationDTO> Locations { get; set; } = new List<NetworkAccessRuleLocationDTO>();
        public List<PortRange> PortRanges { get; set; } = new List<PortRange>();
    }

    [Serializable]
    public class NetworkAccessRuleLocationDTO
    {
        public NetworkAccessRuleLocationDTO() { }
        public NetworkAccessRuleLocationDTO(NetworkAccessRuleLocation location)
        {
            Type = location.Type;
            Value = location.Value;
            Id = location.Id;
        }

        public int Type { get; set; }   //Use NetworkAccessRuleLocationType
        public string Value { get; set; }
        public Guid? Id { get; set; }
    }

}
