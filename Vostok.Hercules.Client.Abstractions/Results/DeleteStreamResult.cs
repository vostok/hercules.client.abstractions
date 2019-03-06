using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Results
{
    [PublicAPI]
    public class DeleteStreamResult : HerculesResult
    {
        public DeleteStreamResult(HerculesStatus status, [CanBeNull] string errorDetails = null)
            : base(status, errorDetails)
        {
        }

        public override bool IsSuccessful
            => Status == HerculesStatus.Success || Status == HerculesStatus.StreamNotFound;
    }
}