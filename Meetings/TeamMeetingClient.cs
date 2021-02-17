using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Microsoft.Teams.Api.Meetings.Models;

namespace Microsoft.Teams.Api.Meetings
{
    public class TeamMeetingClient : ITeamsMeeting
    {
        private readonly string graphApiBaseUrl;
        private readonly AuthenticationContext authenticationContext;
        private readonly ClientCredential clientCredential;
        private readonly ClientAssertion clientAssertion;

        /// <summary>
        ///     Initializes the class of type <see cref="TeamMeetingClient"/>.
        /// </summary>
        /// <param name="authenticationContext">The authentication context for ADAL authentication.</param>
        /// <param name="clientCredential">The client credentials for the authentication context.</param>
        public TeamMeetingClient(
            AuthenticationContext authenticationContext,
            ClientCredential clientCredential)
        {
            this.authenticationContext = authenticationContext;
            this.clientCredential = clientCredential;

            this.graphApiBaseUrl = Constants.GraphApiBaseUrl;
        }

        /// <summary>
        ///     Initializes the class of type <see cref="TeamMeetingClient"/>.
        /// </summary>
        /// <param name="authenticationContext">The authentication context for ADAL authentication.</param>
        /// <param name="clientAssertion">The client assertion for the authentication context.</param>
        public TeamMeetingClient(
            AuthenticationContext authenticationContext,
            ClientAssertion clientAssertion)
        {
            this.authenticationContext = authenticationContext;
            this.clientAssertion = clientAssertion;

            this.graphApiBaseUrl = Constants.GraphApiBaseUrl;
        }

        /// <summary>
        ///     Gets the online meeting information.
        /// </summary>
        /// <param name="meetingId">The meeting id of the teams meeting.</param>
        /// <returns>The online meeting information.</returns>
        public async Task<OnlineMeeting> GetOnlineMeetingsAsync(string meetingId)
        {
            try
            {
                var meetingInformation = await
                    GetOnlineMeetingInformationUsingHttpRequest(meetingId).ConfigureAwait(false);

                return meetingInformation.ToOnlineMeeting();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private async Task<string> GetOnlineMeetingInformationUsingHttpRequest(string meetingId)
        {
            using (var httpClient = new HttpClient())
            {
                var authToken = await this.GetAuthenticationBearerToken();

                httpClient.BaseAddress = new Uri(Constants.GraphApiBaseUrl);
                httpClient.Timeout = TimeSpan.FromSeconds(120);
                httpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", authToken);

                var httpRequestResponse = await httpClient.GetStreamAsync(
                    string.Format(Constants.OnlineMeetingsApi, meetingId));

                using (var streamReader = new StreamReader(httpRequestResponse))
                {
                    return await streamReader.ReadToEndAsync();
                }
            }
        }

        private async Task<string> GetAuthenticationBearerToken()
        {
            try
            {
                var authenticationResult = this.clientCredential == null
                    ? await this.authenticationContext.AcquireTokenAsync(
                        this.graphApiBaseUrl,
                        this.clientAssertion).ConfigureAwait(false)
                    : await this.authenticationContext.AcquireTokenAsync(
                        this.graphApiBaseUrl,
                        this.clientCredential).ConfigureAwait(false);

                return authenticationResult.AccessToken;
            }
            catch (AdalException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
