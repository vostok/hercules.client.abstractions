using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Results
{
    [PublicAPI]
    public class HerculesTimelineReadResult : HerculesResult<HerculesTimelineReadPayload>
    {
        public HerculesTimelineReadResult(HerculesStatus status, HerculesTimelineReadPayload payload)
            : base(status, payload)
        {
        }
    }
}