using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Events;

namespace Vostok.Hercules.Client.Abstractions.Results
{
    [PublicAPI]
    public static class ReadStreamIEnumerableResultExtensions
    {
        public static ReadStreamIEnumerableResult FromGenericResult(this ReadStreamIEnumerableResult<HerculesEvent> result)
        {
            if (result == null)
                return null;

            return result.IsSuccessful
                ? new ReadStreamIEnumerableResult(result.Status, 
                    new ReadStreamIEnumerablePayload(result.Payload.Events, result.Payload.Current, result.Payload.Next, () => result.Payload.Dispose()))
                : new ReadStreamIEnumerableResult(result.Status, null, result.ErrorDetails);
        }
    }
}