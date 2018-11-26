using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Common;

namespace Vostok.Hercules.Client.Abstractions.Queries
{
    [PublicAPI]
    public class CreateTimelineQuery
    {
        public TimelineDescription Description { get; set; }
    }
}