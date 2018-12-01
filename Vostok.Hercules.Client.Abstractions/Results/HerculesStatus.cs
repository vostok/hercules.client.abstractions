using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Results
{
    /// <summary>
    /// Represents the status of an arbitrary request to Hercules APIs.
    /// </summary>
    [PublicAPI]
    public enum HerculesStatus
    {
        /// <summary>
        /// Operation has succeeded.
        /// </summary>
        Success,

        /// <summary>
        /// Operation has failed due to stream absence.
        /// </summary>
        StreamNotFound,

        /// <summary>
        /// Operation has failed due to an already existing stream with given name.
        /// </summary>
        StreamAlreadyExists,

        /// <summary>
        /// Operation has failed due to timeline absence.
        /// </summary>
        TimelineNotFound,

        /// <summary>
        /// Operation has failed due to an already existing timeline with given name.
        /// </summary>
        TimelineAlreadyExists,

        /// <summary>
        /// Operation has failed due to malformed/incorrect/incomplete request data.
        /// </summary>
        IncorrectRequest,

        /// <summary>
        /// Operation has failed due to missing or incorrect API key in request.
        /// </summary>
        Unauthorized,

        /// <summary>
        /// Operation has failed due to insufficient access rights on one or more of entities involved.
        /// </summary>
        InsufficientPermissions,

        /// <summary>
        /// Operation has failed due to excessively large payload in request.
        /// </summary>
        RequestTooLarge,

        /// <summary>
        /// Operation has failed due to server-side throttling.
        /// </summary>
        Throttled,

        /// <summary>
        /// Operation has failed due to expiry of available time before obtaining a meaningful result.
        /// </summary>
        Timeout,

        /// <summary>
        /// Operation has failed due to unclassified error.
        /// </summary>
        UnknownError
    }
}
