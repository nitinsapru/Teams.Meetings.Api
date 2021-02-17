using System;
using Newtonsoft.Json;

namespace Microsoft.Teams.Api.Meetings.Models
{
    public class OnlineMeeting
    {
        [JsonProperty("@odata.type")]
        public string OdataType { get; set; }
        public string AutoAdmittedUsers { get; set; }
        public AudioConferencing AudioConferencing { get; set; }
        public ChatInfo ChatInfo { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Id { get; set; }
        public string JoinWebUrl { get; set; }
        public Participants Participants { get; set; }
        public DateTime StartDateTime { get; set; }
        public string Subject { get; set; }
        public string VideoTeleconferenceId { get; set; }
        public LobbyBypassSettings LobbyBypassSettings { get; set; }
        public bool IsEntryExitAnnounced { get; set; }
        public string AllowedPresenters { get; set; }
    }
}
