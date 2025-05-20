using System;
using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class EmailTemplateType
    {
        public static readonly EmailTemplateType ThreatLockerRequestApproved = new(Guid.Parse("BE7054D0-830B-4A60-990A-F021CC7A6902"), "ThreatLocker Request Approved");
        public static readonly EmailTemplateType ThreatLockerRequestPending = new(Guid.Parse("81A84F07-A08A-4425-B7CB-F236B2E05F22"), "ThreatLocker Request Pending");
        public static readonly EmailTemplateType ThreatLockerRequestDenied = new(Guid.Parse("11CD1401-10DF-44FC-8017-1DE5C671E3C5"), "ThreatLocker Request Denied");
        public static readonly EmailTemplateType ThreatLockerRequestAddedToApplication = new(Guid.Parse("E78E0A20-4213-4EB7-9AA1-DD52D7E42B6B"), "ThreatLocker Request Added To Application");
        public static readonly EmailTemplateType ThreatLockerRequestIgnored = new(Guid.Parse("E17AC37D-A692-4725-B54D-B1E956433777"), "ThreatLocker Request Ignored");
        public static readonly EmailTemplateType EscalationFromCyberHero = new(Guid.Parse("45362EF9-6513-4BD2-8A53-169976EF2DD4"), "Approval Request Escalation from Cyber Hero");
        public static readonly EmailTemplateType EmailForProductTrial = new(Guid.Parse("5D82EF44-1D29-4852-B584-B234F6452420"), "Email For Product Trial");

        public EmailTemplateType(Guid value, string name)
        {
            Value = value;
            Name = name;
        }

        public Guid Value { get; set; }
        public string Name { get; set; }

        public static readonly EmailTemplateType[] All =
       {
            ThreatLockerRequestApproved,
            ThreatLockerRequestPending,
            ThreatLockerRequestDenied,
            ThreatLockerRequestAddedToApplication,
            ThreatLockerRequestIgnored,
            EscalationFromCyberHero,
            EmailForProductTrial
        };

        public static EmailTemplateType Find(Guid value)
        {
            return All.FirstOrDefault(x => x.Value == value);
        }

        public static EmailTemplateType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
