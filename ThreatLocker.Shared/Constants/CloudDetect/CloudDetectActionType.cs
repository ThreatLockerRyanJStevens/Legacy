namespace ThreatLocker.Shared.Constants.CloudDetect
{
    public enum CloudDetectActionType
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
}
