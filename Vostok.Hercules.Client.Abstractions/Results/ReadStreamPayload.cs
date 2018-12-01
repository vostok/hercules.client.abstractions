using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Events;
using Vostok.Hercules.Client.Abstractions.Models;
using Vostok.Hercules.Client.Abstractions.Queries;

namespace Vostok.Hercules.Client.Abstractions.Results
{
    [PublicAPI]
    public class ReadStreamPayload
    {
        public ReadStreamPayload(
            [NotNull] IList<HerculesEvent> events, 
            [NotNull] StreamCoordinates next)
        {
            Events = events ?? throw new ArgumentNullException(nameof(events));
            Next = next ?? throw new ArgumentNullException(nameof(next));
        }

        /// <summary>
        /// Events read from the stream.
        /// </summary>
        [NotNull]
        public IList<HerculesEvent> Events { get; }

        /// <summary>
        /// Coordinates for the next sequential read. Put them in a <see cref="ReadStreamQuery"/> to continue reading from this point.
        /// </summary>
        [NotNull]
        public StreamCoordinates Next { get; }
    }
}