using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Events;

[PublicAPI]
public interface IBinaryEventsReader : IBinaryBufferReader
{
    void ReadContainer(IHerculesTagsBuilder builder);
}