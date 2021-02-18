using System;
using System.Runtime.Serialization;

namespace Teams.Meetings.Api.Meetings.Exceptions
{
    /// <summary>
    ///     Represents the exception thrown if there is an invalid response received from
    ///     Microsoft Teams RESTFul APIs.
    /// </summary>
    public class InvalidResponseFromTeamsApi : Exception
    {
        /// <summary>
        ///     Initializes the class of type <see cref="InvalidResponseFromTeamsApi"/>.
        /// </summary>
        /// <param name="message">The exception message string.</param>
        public InvalidResponseFromTeamsApi(string message)
            : base(message)
        {
        }

        /// <summary>
        ///     Initializes the class of type <see cref="InvalidResponseFromTeamsApi"/>.
        /// </summary>
        /// <param name="message">The exception message string.</param>
        /// <param name="innerException">The inner exception.</param>
        public InvalidResponseFromTeamsApi(
            string message,
            Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        ///     Initializes the class of type <see cref="InvalidResponseFromTeamsApi"/>.
        /// </summary>
        /// <param name="info">The serialization information of the exception.</param>
        /// <param name="context">The streaming context of the exception</param>
        public InvalidResponseFromTeamsApi(
            SerializationInfo info,
            StreamingContext context)
            : base(info, context)
        {
        }
    }
}
