using System;
using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Events
{
    [PublicAPI]
    public class HerculesEvent
    {
        public DateTimeOffset Timestamp { get; }

        public HerculesTags Tags { get; }
    }
}
