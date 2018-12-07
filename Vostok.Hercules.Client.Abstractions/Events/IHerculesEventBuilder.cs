using System;
using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Events
{
    [PublicAPI]
    public interface IHerculesEventBuilder : IHerculesTagsBuilder
    {
        IHerculesEventBuilder SetTimestamp(DateTimeOffset timestamp);
    }
}