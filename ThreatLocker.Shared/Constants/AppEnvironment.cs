namespace ThreatLocker.Shared.Constants
{
    public class AppEnvironment
    {
        public static readonly string Local = "LocalV2";
        public static readonly string Development = "DevelopmentV2";
        public static readonly string Staging = "StagingV2";
        public static readonly string Production = "WebV2";

        public static bool IsDevelopment(string environment)
        {
            return environment == Local || environment == Development;
        }
    }
}
