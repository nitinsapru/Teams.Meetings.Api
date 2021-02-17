using System.Collections.Generic;
using Newtonsoft.Json;

namespace Microsoft.Teams.Api.Meetings.Models
{
    public class Participants
    {
        [JsonProperty("@odata.type")]
        public string OdataType { get; set; }
        public IList<Attendee> Attendees { get; set; }
        public Organizer Organizer { get; set; }
    }
}
