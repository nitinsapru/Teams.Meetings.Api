using Newtonsoft.Json;

namespace Microsoft.Teams.Api.Meetings.Models
{
    public class User
    {
        [JsonProperty("@odata.type")]
        public string OdataType { get; set; }
        public string Id { get; set; }
        public string DisplayName { get; set; }
    }
}
