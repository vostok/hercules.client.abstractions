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
        /// <inheritdoc />
        public void Put(string stream, Action<IHerculesEventBuilder> buildEvent)
        {
        }

        /// <inheritdoc />
        public void ConfigureStream(string stream, StreamSettings settings)
        {
        }
    }
}