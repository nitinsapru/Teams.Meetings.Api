namespace Microsoft.Teams.Api.Meetings.Models
{
    /// <summary>
    ///     Represents the class for audio conferencing.
    /// </summary>
    public class AudioConferencing
    {
        /// <summary>
        ///     Gets or sets the toll contact number for audio conferencing.
        /// </summary>
        public string TollNumber { get; set; }

        /// <summary>
        ///     Gets or sets the toll free contact number for audio conferencing.
        /// </summary>
        public string TollFreeNumber { get; set; }

        /// <summary>
        ///     Gets or sets the conference Id.
        /// </summary>
        public string ConferenceId { get; set; }

        /// <summary>
        ///     Gets or sets the dial-in url for the audio conferencing.
        /// </summary>
        public string DialinUrl { get; set; }
    }
}
