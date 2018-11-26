using System;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Events;

namespace Vostok.Hercules.Client.Abstractions
{
    [PublicAPI]
    public interface IHerculesSink
    {
        void Put([NotNull] string streamName, [NotNull] Action<IHerculesEventBuilder> buildEvent);
    }
}