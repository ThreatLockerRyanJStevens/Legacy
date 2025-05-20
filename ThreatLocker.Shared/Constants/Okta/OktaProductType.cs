using System;
using System.Linq;

namespace ThreatLocker.Shared.Constants.Okta
{
    public class OktaConfigurationType
    {
        public static readonly OktaConfigurationType OAuth0 = new OktaConfigurationType(1,"OAuth0");
        public static readonly OktaConfigurationType Workforce = new OktaConfigurationType(2,"Workforce");

        public string Name { get; set; }
        public int Id { get; set; }

        public OktaConfigurationType(int id, string name)
        {
            Name = name;
            Id = id;
        }

        public static readonly OktaConfigurationType[] All =
        {
            OAuth0,
            Workforce
        };

        public static readonly int[] AllIds =
        {
            OAuth0.Id,
            Workforce.Id
        };

        public static OktaConfigurationType Find(string name)
        {
            return All.FirstOrDefault(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public static OktaConfigurationType FindByValue(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }
    }
}
