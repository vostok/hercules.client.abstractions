using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Results
{
    [PublicAPI]
    public class HerculesStreamReadResult : HerculesResult<HerculesStreamReadPayload>
    {
        public HerculesStreamReadResult(HerculesStatus status, HerculesStreamReadPayload payload)
            : base(status, payload)
        {
        }
    }
}