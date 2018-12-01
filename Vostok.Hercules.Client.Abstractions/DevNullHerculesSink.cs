using System;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Events;

namespace Vostok.Hercules.Client.Abstractions
{
    /// <summary>
    /// An implementation of <see cref="IHerculesSink"/> that simply drops all incoming events.
    /// </summary>
    [PublicAPI]
    public class DevNullHerculesSink : IHerculesSink
    {
        public void Put(string streamName, Action<IHerculesEventBuilder> buildEvent)
        {
        }
    }
}