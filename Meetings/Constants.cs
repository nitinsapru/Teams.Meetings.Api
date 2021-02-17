namespace Microsoft.Teams.Api.Meetings
{
    internal class Constants
    {
        internal const string GraphApiBaseUrl = "https://graph.microsoft.com/v1.0";
        internal const string OnlineMeetingsApi = "/communications/onlineMeetings/?$filter=VideoTeleconferenceId -eq '{0}'";
    }
}
