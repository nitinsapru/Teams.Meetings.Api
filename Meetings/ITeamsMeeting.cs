using System.Threading.Tasks;
using Microsoft.Teams.Api.Meetings.Models;

namespace Microsoft.Teams.Api.Meetings
{
    public interface ITeamsMeeting
    {
        /// <summary>
        ///     Gets the online meeting information.
        /// </summary>
        /// <param name="meetingId">The meeting id of the teams meeting.</param>
        /// <returns>The online meeting information.</returns>
        Task<OnlineMeeting> GetOnlineMeetingsAsync(string meetingId);
    }
}
