using System;
using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Events
{
    [PublicAPI]
    public interface IHerculesEventBuilder : IHerculesTagsBuilder
    {
        [NotNull]
        IHerculesEventBuilder SetTimestamp(DateTimeOffset timestamp);
    }
}