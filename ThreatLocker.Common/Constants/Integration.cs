using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Constants
{
    public class Integration
    {
        public static readonly Integration ConnectWiseManage = new Integration("462C0133-171C-4B0F-ACDD-0943DF7A8C09", "ConnectWise Manage");
        public static readonly Integration DUO = new Integration("23BF6DE0-31D9-4760-88EA-189EFC1AA5B8", "DUO Dual Factor Authentication");
        public static readonly Integration Kaseya = new Integration("704290F7-6CA6-4B0E-95E7-79B060205F3B", "Kaseya");
        public static readonly Integration Splunk = new Integration("634B69C9-FE46-4559-AC5A-DC325D1B9BB0", "Splunk");
        public static readonly Integration ITGlue = new Integration("13EAEA2C-5B52-4FB2-855E-E734517F9DD1", "IT Glue");
        public static readonly Integration Datto = new Integration("8C6F35F6-A17C-4B9F-9BBF-EC63BA950598", "Datto");
        public static readonly Integration ActiveDirectory = new Integration("2363DA00-A135-4BCA-8113-ED00A3574537", "Active Directory");
        public static readonly Integration Azure = new Integration("B35BA03B-EE83-44A0-9037-1D02D2CEE2DF", "Azure");

        public Integration(string typeId, string name)
        {
            IntegrationTypeId = typeId;
            Name = name;
        }

        public string IntegrationTypeId { get; set; }
        public string Name { get; set; }
    }
}
