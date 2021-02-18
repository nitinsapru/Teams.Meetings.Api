namespace Microsoft.Teams.Api.Meetings
{
    /// <summary>
    ///     Represents the constants which are used within the library.
    /// </summary>
    internal class Constants
    {
        internal const string GraphApiBaseUrl = "https://graph.microsoft.com/v1.0";
        internal const string OnlineMeetingsApi = "/communications/onlineMeetings/?$filter=VideoTeleconferenceId -eq '{0}'";
    }
}
