using System;
using Newtonsoft.Json;

namespace Microsoft.Teams.Api.Meetings.Models
{
    public class ChatInfo
    {
        [JsonProperty("@odata.type")]
        public string OdataType { get; set; }
        public string ThreadId { get; set; }
        public string MessageId { get; set; }
    }
}
