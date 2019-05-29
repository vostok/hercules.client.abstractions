using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Results
{
    [PublicAPI]
    public class SeekToEndStreamResult : HerculesResult<SeekToEndStreamPayload>
    {
        public SeekToEndStreamResult(HerculesStatus status, SeekToEndStreamPayload payload, [CanBeNull] string errorDetails = null)
            : base(status, payload, errorDetails)
        {
        }
    }
}