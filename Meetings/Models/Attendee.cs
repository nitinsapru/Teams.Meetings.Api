using Newtonsoft.Json;

namespace Microsoft.Teams.Api.Meetings.Models
{
    /// <summary>
    ///     Represents the attendee of the meeting who are not invited as part of the actual
    ///     meeting invite.
    /// </summary>
    public class Attendee
    {
        /// <summary>
        ///     Gets or sets the identity of the user.
        /// </summary>
        public Identity Identity { get; set; }

        /// <summary>
        ///     Gets or sets the Upn of the user.
        /// </summary>
        public string Upn { get; set; }
    }
}
