namespace Microsoft.Teams.Api.Meetings.Models
{
    /// <summary>
    ///     Represents the organizer of the meeting.
    /// </summary>
    public class Organizer
    {
        /// <summary>
        ///     Gets or sets the identity of the user who is the organizer of the meeting.
        /// </summary>
        public Identity Identity { get; set; }

        /// <summary>
        ///     Gets or sets the Upn for the organizer of the meeting.
        /// </summary>
        public string Upn { get; set; }
    }
}
