using System;
using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class IntegrationType
    {
        public static readonly IntegrationType ConnectWiseManage = new IntegrationType(Guid.Parse("462C0133-171C-4B0F-ACDD-0943DF7A8C09"), "ConnectWise Manage");
        public static readonly IntegrationType DUO = new IntegrationType(Guid.Parse("23BF6DE0-31D9-4760-88EA-189EFC1AA5B8"), "DUO Dual Factor Authentication");
        public static readonly IntegrationType Kaseya = new IntegrationType(Guid.Parse("704290F7-6CA6-4B0E-95E7-79B060205F3B"), "Kaseya");
        public static readonly IntegrationType Splunk = new IntegrationType(Guid.Parse("634B69C9-FE46-4559-AC5A-DC325D1B9BB0"), "Splunk");
        public static readonly IntegrationType ITGlue = new IntegrationType(Guid.Parse("13EAEA2C-5B52-4FB2-855E-E734517F9DD1"), "IT Glue");
        public static readonly IntegrationType Datto = new IntegrationType(Guid.Parse("8C6F35F6-A17C-4B9F-9BBF-EC63BA950598"), "Datto");
        public static readonly IntegrationType ActiveDirectory = new IntegrationType(Guid.Parse("2363DA00-A135-4BCA-8113-ED00A3574537"), "Active Directory");
        public static readonly IntegrationType Azure = new IntegrationType(Guid.Parse("B35BA03B-EE83-44A0-9037-1D02D2CEE2DF"), "Azure");
        public static readonly IntegrationType SAML = new IntegrationType(Guid.Parse("A5B62A10-C9DD-40C2-B801-ED654983E5F6"), "SAML");
        public static readonly IntegrationType OKTA = new IntegrationType(Guid.Parse("3DE9CA0B-9331-4D77-9C24-8EC94C4F3178"), "OKTA");
        public static readonly IntegrationType HaloPSA = new IntegrationType(Guid.Parse("6E771BC6-07A3-4B14-8C0F-4FA897CEDEA6"), "HaloPSA");

        public static readonly IntegrationType ServiceNow = new IntegrationType(Guid.Parse("7E9BBC6B-9604-4B47-9053-8639243A7291"), "ServiceNow");
        public static readonly IntegrationType Office365 = new IntegrationType(Guid.Parse("A4968EAB-38C9-4698-A34E-CD7EF4F3B0CD"), "Office 365 Connector");
        public static readonly IntegrationType SharePoint = new IntegrationType(Guid.Parse("44C5B53F-CD6D-4DCD-A0A8-5DB717BBF310"), "SharePoint Connector");

        public IntegrationType(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public static readonly IntegrationType[] All =
        {
            ConnectWiseManage, 
            DUO, 
            Kaseya, 
            Splunk, 
            ITGlue, 
            Datto, 
            ActiveDirectory,
            Azure,
            SAML,
            OKTA,
            ServiceNow,
            Office365,
            SharePoint,
            HaloPSA,
        };

        public static IntegrationType Find(Guid id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static IntegrationType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
