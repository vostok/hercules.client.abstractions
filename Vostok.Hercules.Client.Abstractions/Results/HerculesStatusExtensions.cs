using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Results
{
    [PublicAPI]
    public static class HerculesStatusExtensions
    {
        /// <summary>
        /// Returns <c>true</c> if given <paramref name="status"/> is <see cref="HerculesStatus.Success"/> or <c>false</c> otherwise.
        /// </summary>
        public static bool IsSuccessful(this HerculesStatus status) =>
            status == HerculesStatus.Success;

        /// <summary>
        /// Throws a <see cref="HerculesException"/> if given <paramref name="status"/> is not <see cref="IsSuccessful"/>.
        /// </summary>
        public static void EnsureSuccess(this HerculesStatus status)
        {
            if (IsSuccessful(status))
                throw new HerculesException(status);
        }
    }
}