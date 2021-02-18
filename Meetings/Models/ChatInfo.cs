namespace Microsoft.Teams.Api.Meetings.Models
{
    /// <summary>
    ///     Represents the chat information class.
    /// </summary>
    public class ChatInfo
    {
        /// <summary>
        ///     Gets or sets the threadId of the chat conversation.
        /// </summary>
        public string ThreadId { get; set; }

        /// <summary>
        ///     Gets or sets the messageId of the chat conversation.
        /// </summary>
        public string MessageId { get; set; }
    }
}
