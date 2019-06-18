using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Events
{
    [PublicAPI]
    public interface IBinaryBufferReader
    {
        byte[] Buffer { get; }
        long Position { get; set; }
        bool SkipMode { get; set; }
    }
}