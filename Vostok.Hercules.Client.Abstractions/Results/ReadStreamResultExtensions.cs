using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Events;

namespace Vostok.Hercules.Client.Abstractions.Results
{
    [PublicAPI]
    public static class ReadStreamResultExtensions
    {
        public static ReadStreamResult FromGenericResult(this ReadStreamResult<HerculesEvent> result)
        {
            if (result == null)
                return null;

            return result.IsSuccessful
                ? new ReadStreamResult(result.Status, new ReadStreamPayload(result.Payload.Events, result.Payload.Next))
                : new ReadStreamResult(result.Status, null, result.ErrorDetails);
        }

        public static ReadStreamResult<HerculesEvent> ToGenericResult(this ReadStreamResult result)
        {
            if (result == null)
                return null;

            return result.IsSuccessful
                ? new ReadStreamResult<HerculesEvent>(result.Status, result.Payload)
                : new ReadStreamResult<HerculesEvent>(result.Status, null, result.ErrorDetails);
        }
    }
}