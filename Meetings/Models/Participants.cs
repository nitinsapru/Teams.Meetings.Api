using System.Collections.Generic;

namespace Microsoft.Teams.Api.Meetings.Models
{
    /// <summary>
    ///     Represents the participants of the meeting.
    /// </summary>
    public class Participants
    {
        /// <summary>
        ///     Gets or sets the list of attendees of the meeting.
        /// </summary>
        public IList<Attendee> Attendees { get; set; }

        /// <summary>
        ///     Gets or sets the organizer of the meeting.
        /// </summary>
        public Organizer Organizer { get; set; }
    }
}
