using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Results
{
    [PublicAPI]
    public class ReadTimelineResult<T> : HerculesResult<ReadTimelinePayload<T>>
    {
        public ReadTimelineResult(HerculesStatus status, ReadTimelinePayload<T> payload, [CanBeNull] string errorDetails = null)
            : base(status, payload, errorDetails)
        {
        }
    }
}