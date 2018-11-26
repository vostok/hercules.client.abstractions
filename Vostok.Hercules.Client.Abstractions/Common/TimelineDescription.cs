using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Common
{
    [PublicAPI]
    public class TimelineDescription
    {
        public string Name { get; set; }

        public int ShardsCount { get; set; }

        // ...
    }
}