using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Common
{
    [PublicAPI]
    public class StreamDescription
    {
        public string Name { get; set; }

        public StreamType Type { get; set; }

        public int ShardsCount { get; set; }

        // ...
    }
}
