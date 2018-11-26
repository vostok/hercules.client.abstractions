using System;
using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Events
{
    // TODO(iloktionov): 2 implementations: ordinary and binary inside IHerculesSink

    [PublicAPI]
    public interface IHerculesEventBuilder : IHerculesTagsBuilder
    {
        IHerculesEventBuilder SetTimestamp(DateTimeOffset timestamp);
    }
}