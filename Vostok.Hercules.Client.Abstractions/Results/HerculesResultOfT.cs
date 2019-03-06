using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Results
{
    /// <summary>
    /// Represents the result of an arbitrary request to Hercules APIs that returns some kind of payload.
    /// </summary>
    [PublicAPI]
    public class HerculesResult<TPayload> : HerculesResult
    {
        private readonly TPayload payload;

        public HerculesResult(HerculesStatus status, TPayload payload, [CanBeNull] string errorDetails = null)
            : base(status, errorDetails)
        {
            this.payload = payload;
        }

        /// <summary>
        /// Returns the payload, but only if this result <see cref="HerculesResult.IsSuccessful"/>. Otherwise, a <see cref="HerculesException"/> is thrown.
        /// </summary>
        public TPayload Payload => ((HerculesResult<TPayload>)EnsureSuccess()).payload;
    }
}