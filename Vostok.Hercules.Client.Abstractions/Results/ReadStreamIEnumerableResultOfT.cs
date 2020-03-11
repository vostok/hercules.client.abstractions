using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Results
{
    [PublicAPI]
    public class ReadStreamIEnumerableResult<T> : HerculesResult<ReadStreamIEnumerablePayload<T>>
    {
        public ReadStreamIEnumerableResult(HerculesStatus status, ReadStreamIEnumerablePayload<T> payload, [CanBeNull] string errorDetails = null)
            : base(status, payload, errorDetails)
        {
        }
    }
}