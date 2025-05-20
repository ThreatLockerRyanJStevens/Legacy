namespace ThreatLocker.Shared.Constants
{
    /// <summary>
    /// TODO There were hard code text in procedure. [dbo].[WEBUI_TouchPointGetTradeShowDetails]
    /// </summary>
    public class TouchPointTypes
    {
        public static readonly TouchPointTypes TradeShow = new TouchPointTypes("Trade Show");
        public static readonly TouchPointTypes AuditReview = new TouchPointTypes("Audit Review");
        public static readonly TouchPointTypes SEDemo = new TouchPointTypes("SE Demo");
        public static readonly TouchPointTypes Deployment = new TouchPointTypes("Deployment");

        public TouchPointTypes(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public static readonly string TrialStarted = "Trial Started";
    }
}