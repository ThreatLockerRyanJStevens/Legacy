using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ThreatLockerCommon.Enums
{
    public enum eCloudDetectAction
    {
        CreateAlert = 1,
        SendEmail = 2,
        CreateTicket = 3,
        CallWebhook = 4,
        CallRestAPI = 5,
        CreateKaseyaTicket = 6,
        CreateDattoTicket = 7,
        CreateConnectwiseTicket = 8,
        SendPushNotification = 9,
        CyberHeroDetectionAndResponse = 10,
        CreateHaloPSATicket = 11,
        LockoutAccount = 12,
    }

    public enum eCloudDetectActionDataField
    {
        ServiceNotes = 0,
        AlertSeverity = 1,
        AlertThreatLevel = 2,
        AlertSummary = 3,
        AlertDetails = 4,
        EmailRecipients = 5,
        EmailSubject = 6,
        EmailBody = 7,
        WebhookMethod = 8,
        WebhookURL = 9,
        WebhookContentType = 10,
        WebhookHeaders = 11,
        WebhookBody = 12,
        RestAPIMethod = 13,
        RestAPIURL = 14,
        RestAPIContentType = 15,
        RestAPIHeaders = 16,
        RestAPIBody = 17,
        KaseyaTicketSubject = 18,
        KaseyaTicketBody = 19,
        DattoTicketSubject = 20,
        DattoTicketBody = 21,
        ConnectwiseTicketSubject = 22,
        ConnectwiseTicketBody = 23,
        PushNotificationAdministrators = 24,
        CyberHeroDetectionAndResponse = 25,
        HaloPSATicketSubject = 26,
        HaloPSATicketBody = 27,
        LockoutAccount = 28,
    }

    public static class CloudDetectConnector
    {
        public static class Office365Management
        {
            public enum Audit
            {
                [Description("Audit.AzureActiveDirectory")]
                AzureAD = 6,

                [Description("Audit.Exchange")]
                Exchange = 7,

                [Description("Audit.General")]
                General = 8,

                [Description("Audit.SharePoint")]
                SharePoint = 9,
            }

            public enum DLP
            {
                [Description("DLP.All")]
                All = 12,
            }

            public static List<Enum> ContentTypes = new List<Enum>
            {
                Audit.AzureAD,
                Audit.Exchange,
                Audit.General,
                Audit.SharePoint,
                DLP.All,
            };
        }

        public enum MicrosoftGraph
        {
            DirectoryAudit = 10,
            SecurityAlert = 11,
            RiskDetection = 13,
        }
    }
}
