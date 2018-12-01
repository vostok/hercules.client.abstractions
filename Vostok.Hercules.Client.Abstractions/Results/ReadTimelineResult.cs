using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Results
{
    [PublicAPI]
    public class ReadTimelineResult : HerculesResult<ReadTimelinePayload>
    {
        public ReadTimelineResult(HerculesStatus status, ReadTimelinePayload payload)
            : base(status, payload)
        {
        }
    }
}