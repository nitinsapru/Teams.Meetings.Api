using System;
using Newtonsoft.Json;

namespace Microsoft.Teams.Api.Meetings.Models
{
    public class Organizer
    {
        [JsonProperty("@odata.type")]
        public string OdataType { get; set; }
        public Identity Identity { get; set; }
        public string Upn { get; set; }
    }
}
