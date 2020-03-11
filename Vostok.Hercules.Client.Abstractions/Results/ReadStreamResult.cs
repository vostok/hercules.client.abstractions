using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Events;

namespace Vostok.Hercules.Client.Abstractions.Results
{
    [PublicAPI]
    public class ReadStreamResult : ReadStreamResult<HerculesEvent>
    {
        public ReadStreamResult(HerculesStatus status, ReadStreamPayload payload, [CanBeNull] string errorDetails = null)
            : base(status, payload, errorDetails)
        {
        }
    }
}