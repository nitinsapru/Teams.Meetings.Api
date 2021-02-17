using System.Globalization;
using Microsoft.Teams.Api.Meetings.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Microsoft.Teams.Api.Meetings
{
    public static class TeamMeetingClientExtensions
    {
        private static JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            Formatting = Formatting.Indented,
            Culture = CultureInfo.InvariantCulture
        };

        /// <summary>
        ///     Converts input Http response string to <see cref="OnlineMeeting"/>.
        /// </summary>
        /// <param name="httpResponseString">The HTTP response string.</param>
        /// <returns>The online meeting content.</returns>
        public static OnlineMeeting ToOnlineMeeting(this string httpResponseString)
        {
            try
            {
                var jsonDeserializedObject = JsonConvert.DeserializeObject<OnlineMeeting>(
                    httpResponseString,
                    jsonSerializerSettings);

                if (jsonDeserializedObject == null)
                {
                    return default;
                }

                return jsonDeserializedObject;
            }
            catch(JsonSerializationException)
            {
                throw;
            }
        }
    }
}
