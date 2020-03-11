using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Events;

namespace Vostok.Hercules.Client.Abstractions.Results
{
    [PublicAPI]
    public class ReadStreamIEnumerableResult : ReadStreamIEnumerableResult<HerculesEvent>
    {
        public ReadStreamIEnumerableResult(HerculesStatus status, ReadStreamIEnumerablePayload<HerculesEvent> payload, [CanBeNull] string errorDetails = null)
            : base(status, payload, errorDetails)
        {
        }
    }
}