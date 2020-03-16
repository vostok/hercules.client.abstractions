using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Events;

namespace Vostok.Hercules.Client.Abstractions.Results
{
    [PublicAPI]
    public static class ReadTimelineResultExtensions
    {
        public static ReadTimelineResult FromGenericResult(this ReadTimelineResult<HerculesEvent> result)
        {
            if (result == null)
                return null;

            return result.IsSuccessful
                ? new ReadTimelineResult(result.Status, new ReadTimelinePayload(result.Payload.Events, result.Payload.Next))
                : new ReadTimelineResult(result.Status, null, result.ErrorDetails);
        }

        public static ReadTimelineResult<HerculesEvent> ToGenericResult(this ReadTimelineResult result)
        {
            if (result == null)
                return null;

            return result.IsSuccessful
                ? new ReadTimelineResult<HerculesEvent>(result.Status, result.Payload)
                : new ReadTimelineResult<HerculesEvent>(result.Status, null, result.ErrorDetails);
        }
    }
}