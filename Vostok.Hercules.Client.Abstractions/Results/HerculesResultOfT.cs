using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Results
{
    [PublicAPI]
    public class HerculesResult<TPayload> : HerculesResult
    {
        private readonly TPayload payload;

        public HerculesResult(HerculesStatus status, TPayload payload)
            : base(status)
        {
            this.payload = payload;
        }

        public TPayload Payload => ((HerculesResult<TPayload>) EnsureSuccess()).payload;
    }
}
