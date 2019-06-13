using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Results
{
    [PublicAPI]
    public class ReadStreamResult<T> : HerculesResult<ReadStreamPayload<T>>
    {
        public ReadStreamResult(HerculesStatus status, ReadStreamPayload<T> payload, [CanBeNull] string errorDetails = null)
            : base(status, payload, errorDetails)
        {
        }
    }
}