using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Queries
{
    [PublicAPI]
    public class ReadTimelineQuery
    {
        public string TimelineName { get; set; }
    }
}