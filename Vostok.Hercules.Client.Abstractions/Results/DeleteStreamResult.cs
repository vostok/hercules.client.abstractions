using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Results
{
    [PublicAPI]
    public class DeleteStreamResult : HerculesResult
    {
        public DeleteStreamResult(HerculesStatus status)
            : base(status)
        {
        }

        public override bool IsSuccessful 
            => Status == HerculesStatus.Success || Status == HerculesStatus.StreamNotFound;
    }
}