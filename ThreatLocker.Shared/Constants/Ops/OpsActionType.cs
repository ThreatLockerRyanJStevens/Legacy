namespace ThreatLocker.Shared.Constants.Ops
{
    public enum OpsActionType
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
    }
}
