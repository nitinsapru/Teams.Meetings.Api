using Newtonsoft.Json;

namespace Microsoft.Teams.Api.Meetings.Models
{
    public class Attendee
    {
        [JsonProperty("@odata.type")]
        public string OdataType { get; set; }
        public Identity Identity { get; set; }
        public string Upn { get; set; }
    }
}
