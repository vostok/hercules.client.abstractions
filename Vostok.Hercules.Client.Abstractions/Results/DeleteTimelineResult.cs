using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Results
{
    [PublicAPI]
    public class DeleteTimelineResult : HerculesResult
    {
        public DeleteTimelineResult(HerculesStatus status, [CanBeNull] string errorDetails = null)
            : base(status, errorDetails)
        {
        }

        public override bool IsSuccessful
            => Status == HerculesStatus.Success || Status == HerculesStatus.TimelineNotFound;
    }
}