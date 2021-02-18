using System;

namespace Microsoft.Teams.Api.Meetings.Models
{
    /// <summary>
    ///     Represents the online meeting information retrieved from the Microsoft Teams
    ///     RESTFul APIs.
    /// </summary>
    public class OnlineMeeting
    {
        /// <summary>
        ///     Gets or sets the auto admitted users for the meeting.
        /// </summary>
        public string AutoAdmittedUsers { get; set; }

        /// <summary>
        ///     Gets or sets the audio conferencing information for the online meeting.
        /// </summary>
        public AudioConferencing AudioConferencing { get; set; }

        /// <summary>
        ///     Gets or sets the chat information for the online meeting.
        /// </summary>
        public ChatInfo ChatInfo { get; set; }

        /// <summary>
        ///     Gets or sets the datetime of the creation of meeting.
        /// </summary>
        public DateTime CreationDateTime { get; set; }

        /// <summary>
        ///     Gets or sets the datetime of the end of the meeting.
        /// </summary>
        public DateTime EndDateTime { get; set; }

        /// <summary>
        ///     Gets or sets the Id of the online meeting.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        ///     Gets or sets the web url for joining the online meeting.
        /// </summary>
        public string JoinWebUrl { get; set; }

        /// <summary>
        ///     Gets or sets the participants of the meeting.
        /// </summary>
        public Participants Participants { get; set; }

        /// <summary>
        ///     Gets or sets the start datetime of the online meeting.
        /// </summary>
        public DateTime StartDateTime { get; set; }

        /// <summary>
        ///     Gets or sets the subject of the online meeting.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        ///     Gets or sets the video teleconference Id of the meeting.
        /// </summary>
        public string VideoTeleconferenceId { get; set; }

        /// <summary>
        ///     Gets or sets the lobby bypass settings of the meeting.
        /// </summary>
        public LobbyBypassSettings LobbyBypassSettings { get; set; }

        /// <summary>
        ///     Gets or sets the value which determines if the entry and exit is announced or not.
        /// </summary>
        public bool IsEntryExitAnnounced { get; set; }

        /// <summary>
        ///     Gets or sets the allowed presenters for the meeting.
        /// </summary>
        public string AllowedPresenters { get; set; }
    }
}
