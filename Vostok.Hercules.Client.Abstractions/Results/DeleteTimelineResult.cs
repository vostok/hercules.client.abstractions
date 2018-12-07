using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Results
{
    [PublicAPI]
    public class DeleteTimelineResult : HerculesResult
    {
        public DeleteTimelineResult(HerculesStatus status)
            : base(status)
        {
        }

        public override bool IsSuccessful
            => Status == HerculesStatus.Success || Status == HerculesStatus.TimelineNotFound;
    }
}