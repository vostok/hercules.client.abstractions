using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Results
{
    /// <summary>
    /// Represents the result of an arbitrary request to Hercules APIs.
    /// </summary>
    [PublicAPI]
    public class HerculesResult
    {
        public HerculesResult(HerculesStatus status, [CanBeNull] string errorDetails = null)
        {
            Status = status;
            ErrorDetails = errorDetails;
        }

        public HerculesStatus Status { get; }

        [CanBeNull]
        public string ErrorDetails { get; }

        /// <summary>
        /// Returns <c>true</c> if operation completed successfully or <c>false</c> otherwise.
        /// </summary>
        public virtual bool IsSuccessful => Status == HerculesStatus.Success;

        /// <summary>
        /// Throws a <see cref="HerculesException"/> if this result represents an operation which is not <see cref="IsSuccessful"/>.
        /// </summary>
        public HerculesResult EnsureSuccess()
        {
            if (!IsSuccessful)
                throw new HerculesException(Status, ErrorDetails);

            return this;
        }

        public override string ToString()
        {
            return Status.ToString();
        }
    }
}