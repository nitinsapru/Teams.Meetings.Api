using System;
namespace Microsoft.Teams.Api.Meetings.Models
{
    public class LobbyBypassSettings
    {
        public string Scope { get; set; }
        public bool IsDialInBypassEnabled { get; set; }
    }
}
