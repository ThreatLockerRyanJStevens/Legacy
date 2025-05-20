using System;

namespace ThreatLockerCommon.Constants
{
    public class MessageTemplateId
    {
        public static Guid RequestNotificationSMS => new Guid("E009B611-541A-4784-A00E-26F18C100B2E");
        public static Guid PasswordReset => new Guid("F040251B-B4FF-486C-BF60-4CAE9654D45E");
        public static Guid CyberHeroEscalate => new Guid("E65CE5A4-6979-48EA-8AB5-57DF922164EF");
        public static Guid RequestNotificationEmail => new Guid("53186C93-99B1-48CA-8BEF-66B58D5C9901");
        public static Guid HelpDeskNotification => new Guid("6F80898A-DD31-4F6D-9723-7D4595E18283");
        public static Guid Invoice => new Guid("470AA898-819C-40DF-9486-96846A8FA934");
        public static Guid ThreatLockerRequestApproved => new Guid("6F2D8FF7-EDC8-4D47-9DA0-98E5EAB9D1A0");
        public static Guid ThreatLockerStorageRequestApproved => new Guid("39056EA1-D548-4915-BFCE-A9287B52A03E");
        public static Guid InviteAdmin => new Guid("D9536A76-D727-47A2-BB5C-B9C50B0C3A4E");
        public static Guid ThreatLockerElevationRequestApproved => new Guid("03C64AD4-18FB-4F16-AE11-C0D0318BDFEF");
        public static Guid NewTrial => new Guid("5BB2BDAE-88C3-4CDC-AF5E-E34739E16087");
        public static Guid InvoicePaymentFailed => new Guid("E6266920-DCD9-4723-B9E8-25A11610FC8E");
        public static Guid CardPaymentDecline => new Guid("E40F45F7-D251-49F8-B352-7DD700B86A6F");
        public static Guid AutomatedInvoicingReport => new Guid("C2AF4A5D-717E-4B85-9ABA-F4BBE88EC81D");
        public static Guid ThreatLockerRequestSelfApproved => new Guid("4FD632CE-7C55-402C-A1CC-37ADCA1DFF9D");

	}
}
