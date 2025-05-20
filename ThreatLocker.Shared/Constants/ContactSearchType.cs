using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Constants
{
    public class ContactSearchType
    {
        public static readonly ContactSearchType FullNames = new ContactSearchType("name", "Full Names");
        public static readonly ContactSearchType EmailAddresses = new ContactSearchType("email", "Email Addresses");
        public static readonly ContactSearchType PhoneNumbers = new ContactSearchType("phone", "Phone Numbers");
        public static readonly ContactSearchType Usernames = new ContactSearchType("username", "Usernames");
        public static readonly ContactSearchType Hostname = new ContactSearchType("organization", "Organizations");

        public ContactSearchType(string value, string name)
        {
            Value = value;
            Name = name;
        }

        public string Value { get; set; }
        public string Name { get; set; }

        public static readonly ContactSearchType[] All =
       {
            FullNames,
            EmailAddresses,
            PhoneNumbers,
            Usernames,
            Hostname
        };

        public static ContactSearchType Find(string value)
        {
            return All.FirstOrDefault(x => x.Value == value);
        }

        public static ContactSearchType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }

    }
}
