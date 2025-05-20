using System.ComponentModel;

namespace ThreatLockerCommon.Enums
{
    public enum eOpsPolicyConditionMatchType
    {
        MatchAnyConditions = 0,
        MatchAllConditions = 1,
        Combined = 3
    }

    public enum eOpsCondition
    {
        Username = 1,
        ProcessPath = 2,
        ProcessID = 3,
        CreatedByProcess = 4,
        ApplicationPolicy = 5,
        Application = 7,
        ActionType = 9,
        FullPath = 10,
        ThreatLockerHash = 11,
        SHA256 = 12,
        FileSize = 13,
        DeviceType = 14,
        Certificates = 15,
        SourceIPAddress = 16,
        Hostname = 17,
        DestinationPort = 19,
        RemotePresence = 22,
        EventLogID = 23,
        NetworkDirection = 24,
        DestinationIPAddress = 25,
        PolicyAction = 26,
        CMDLineParameters = 27,
        ElevationStatus = 28,
        EncryptionStatus = 29,
        KillRunningProcess = 31,
        MonitorOnly = 34,
        Ringfenced = 35,
        SerialNumber = 37,
        EventLogDescription = 40,
        Occurrences = 41,
        CurrentThreatLevel = 42,
        CanaryFilePath = 44,
        DestinationDomain = 45,
    }
    public enum eOpsOperator
    {
        Matches = 1,
        DoesNotMatch = 2,
        StartsWith = 3,
        EndsWith = 4,
        Contains = 5,
        DoesNotContain = 6,
        RegExMatches = 7,
        LessThan = 8,
        LessThanOrEqualTo = 9,
        GreaterThan = 10,
        GreaterThanOrEqualTo = 11
    }
    public enum eOpsAction
    {
        CreateAlert = 1,
        SendEmail = 2,
        CreateTicket = 3,
        EnableApplicationPolicy = 4,
        DisableApplicationPolicy = 5,
        CallWebhook = 6,
        CallRestAPI = 7,
        EnableStoragePolicy = 8,
        DisableStoragePolicy = 9,
        EnableNetworkControlPolicy = 10,
        DisableNetworkControlPolicy = 11,
        IncreaseThreatLevel = 15,
        IsolateMachine = 16,
        LockdownMachine = 17,
        CreateKaseyaTicket = 18,
        CreateDattoTicket = 19,
        CreateConnectwiseTicket = 20,
        SendPushNotification = 21,
        CallWebhookClient = 22,
        CallRestAPIClient = 23,
        CyberHeroDetectionAndResponse = 24,
        CreateHaloPSATicket = 25,
        InitiateWindowsDefenderScan = 26,
        IncreaseBuiltInThreatLevel = 27
    }

    public enum eOpsActionDataField
    {
        RestAPIMethod = 1,
        RestAPIURL = 2,
        RestAPIContentType = 3,
        RestAPIHeaders = 4,
        RestAPIBody = 5,
        WebhookMethod = 6,
        WebhookURL = 7,
        WebhookContentType = 9,
        WebhookHeaders = 10,
        WebhookBody = 11,
        AlertSeverity = 12,
        AlertSummary = 13,
        AlertDetails = 14,
        EmailRecipients = 15,
        EmailSubject = 18,
        EmailBody = 19,
        EnableApplicationPolicyId = 41,
        DisableApplicationPolicyId = 42,
        EnableStoragePolicyId = 43,
        DisableStoragePolicyId = 44,
        EnableNetworkPolicyId = 45,
        DisableNetworkPolicyId = 46,
        IncreaseThreatLevel = 50,
        IsolateMachine = 51,
        LockdownMachine = 60,
        AlertThreatLevel = 61,
        KaseyaTicketSubject = 62,
        KaseyaTicketBody = 63,
        DattoTicketSubject = 64,
        DattoTicketBody = 65,
        ConnectwiseTicketSubject = 66,
        ConnectwiseTicketBody = 67,
        PushNotificationAdministrators = 68,
        ServiceNotes = 69,
        CallWebhookClientMethod = 70,
        CallWebhookClientURL = 71,
        CallWebhookClientContentType = 72,
        CallWebhookClientHeaders = 73,
        CallWebhookClientBody = 74,
        CallRestAPIClientMethod = 75,
        CallRestAPIClientURL = 76,
        CallRestAPIClientContentType = 77,
        CallRestAPIClientHeaders = 78,
        CallRestAPIClientBody = 79,
        CyberHeroDetectionAndResponse = 80,
        HaloPSATicketBody = 81,
        HaloPSATicketSubject = 82,
        PushNotificationBody = 83,
    }
    public enum eOpsAlertSeverity
    {
        Information = 2,
        Warning = 3,
        Severe = 4
    }
}
