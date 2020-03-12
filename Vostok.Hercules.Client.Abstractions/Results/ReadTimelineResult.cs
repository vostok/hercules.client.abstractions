using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Events;

namespace Vostok.Hercules.Client.Abstractions.Results
{
    [PublicAPI]
    public class ReadTimelineResult : ReadTimelineResult<HerculesEvent>
    {
        public ReadTimelineResult(HerculesStatus status, ReadTimelinePayload<HerculesEvent> payload, [CanBeNull] string errorDetails = null)
            : base(status, payload, errorDetails)
        {
        }
    }
}