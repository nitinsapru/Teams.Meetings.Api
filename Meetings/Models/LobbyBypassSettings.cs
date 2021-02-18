namespace Microsoft.Teams.Api.Meetings.Models
{
    /// <summary>
    ///     Represents the lobby bypass settings for the meeting.
    /// </summary>
    public class LobbyBypassSettings
    {
        /// <summary>
        ///     Gets or sets the scope of the lobby bypass.
        /// </summary>
        public string Scope { get; set; }

        /// <summary>
        ///     Gets or sets the value which determines if the lobby bypass is enabled or not.
        /// </summary>
        public bool IsDialInBypassEnabled { get; set; }
    }
}
