using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Events;
using Vostok.Hercules.Client.Abstractions.Models;

namespace Vostok.Hercules.Client.Abstractions.Results
{
    [PublicAPI]
    public class HerculesStreamReadPayload
    {
        public HerculesStreamReadPayload(
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
        /// Coordinates for the next sequential read.
        /// </summary>
        [NotNull]
        public StreamCoordinates Next { get; }
    }
}