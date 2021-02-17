using System;
namespace Microsoft.Teams.Api.Meetings.Models
{
    public class AudioConferencing
    {
        public string TollNumber { get; set; }
        public string TollFreeNumber { get; set; }
        public string ConferenceId { get; set; }
        public string DialinUrl { get; set; }
    }
}
