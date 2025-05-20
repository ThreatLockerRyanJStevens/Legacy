using System;
using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class MessageTemplateType
    {
        public static readonly MessageTemplateType HelpDeskNotification = new MessageTemplateType(Guid.Parse("6F80898A-DD31-4F6D-9723-7D4595E18283"), "Help Desk Notification");
        public static readonly MessageTemplateType ApprovalRequestIgnore = new MessageTemplateType(Guid.Parse("E17AC37D-A692-4725-B54D-B1E956433777"), "Approval Request Ignore");
        public static readonly MessageTemplateType InviteAdmin = new MessageTemplateType(Guid.Parse("D9536A76-D727-47A2-BB5C-B9C50B0C3A4E"), "Invite Admin");
        public static readonly MessageTemplateType CyberHeroEscalate = new MessageTemplateType(Guid.Parse("E65CE5A4-6979-48EA-8AB5-57DF922164EF"), "Cyber Hero Escalate");
        public static readonly MessageTemplateType ThreatLockerRequestApproved = new MessageTemplateType(Guid.Parse("6F2D8FF7-EDC8-4D47-9DA0-98E5EAB9D1A0"), "ThreatLocker Request Approved");
        public static readonly MessageTemplateType ThreatLockerElevationRequestApproved = new MessageTemplateType(Guid.Parse("03C64AD4-18FB-4F16-AE11-C0D0318BDFEF"), "ThreatLocker Elevation Request Approved");
        public static readonly MessageTemplateType ThreatLockerStorageRequestApproved = new MessageTemplateType(Guid.Parse("39056EA1-D548-4915-BFCE-A9287B52A03E"), "ThreatLocker Storage Request Approved");
        public static readonly MessageTemplateType ExcludedDomainMessage = new MessageTemplateType(Guid.Parse("558197B5-B07B-4346-B1FE-63951E73E420"), "ThreatLocker Excluded Domain Message");
        public static readonly MessageTemplateType NewTrialMessage = new MessageTemplateType(Guid.Parse("5BB2BDAE-88C3-4CDC-AF5E-E34739E16087"), "ThreatLocker New Trial");
        public static readonly MessageTemplateType Invoice = new MessageTemplateType(Guid.Parse("470AA898-819C-40DF-9486-96846A8FA934"), "ThreatLocker Invoice");
        public static readonly MessageTemplateType CardPaymentDecline = new MessageTemplateType(Guid.Parse("E40F45F7-D251-49F8-B352-7DD700B86A6F"), "Card Payment Decline");
        public static readonly MessageTemplateType TaxCertificateUploaded = new MessageTemplateType(Guid.Parse("BFC00B67-6328-4D6B-AD10-BB2F1FD36785"), "Tax Certificate Uploaded");
        public static readonly MessageTemplateType AccessDeviceInvitation = new MessageTemplateType(Guid.Parse("5058eb93-c9e5-4bb3-94a4-51acaeed41c5"), "Access Device Invite");
        public static readonly MessageTemplateType ThreatLockerWebControlRequestApproved = new MessageTemplateType(Guid.Parse("FA14E2B8-C2E4-4289-9584-67A8A344940B"), "ThreatLocker Web Control Request Approved");

        public MessageTemplateType(Guid value, string name)
        {
            Value = value;
            Name = name;
        }

        public Guid Value { get; set; }
        public string Name { get; set; }

        public static readonly MessageTemplateType[] All =
       {
            HelpDeskNotification,
            ApprovalRequestIgnore,
            InviteAdmin,
            CyberHeroEscalate,
            ThreatLockerRequestApproved,
            ThreatLockerElevationRequestApproved,
            ThreatLockerStorageRequestApproved,
            ExcludedDomainMessage,
            NewTrialMessage,
            Invoice,
            CardPaymentDecline,
            AccessDeviceInvitation,
            ThreatLockerWebControlRequestApproved
        };

        public static MessageTemplateType Find(Guid value)
        {
            return All.FirstOrDefault(x => x.Value == value);
        }

        public static MessageTemplateType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
