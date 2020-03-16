using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Results
{
    [PublicAPI]
    public class ReadStreamResult : HerculesResult<ReadStreamPayload>
    {
        public ReadStreamResult(HerculesStatus status, ReadStreamPayload payload, [CanBeNull] string errorDetails = null)
            : base(status, payload, errorDetails)
        {
        }
    }
}