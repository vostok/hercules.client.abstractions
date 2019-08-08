using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Models;
using Vostok.Hercules.Client.Abstractions.Queries;

namespace Vostok.Hercules.Client.Abstractions.Results
{
    [PublicAPI]
    public class ReadTimelinePayload<T>
    {
        public ReadTimelinePayload(
            [NotNull] IList<T> events,
            [NotNull] TimelineCoordinates next)
        {
            Events = events ?? throw new ArgumentNullException(nameof(events));
            Next = next ?? throw new ArgumentNullException(nameof(next));
        }

        /// <summary>
        /// Events read from the timeline.
        /// </summary>
        [NotNull]
        public IList<T> Events { get; }

        /// <summary>
        /// <para>Coordinates for the next sequential read (if the requested time range was not completely consumed).</para>
        /// <para>Put them in a <see cref="ReadTimelineQuery"/> to continue reading from this point.</para>
        /// <para>Don't use them for reads with a different time range from the one used in this operation!</para>
        /// </summary>
        [NotNull]
        public TimelineCoordinates Next { get; }
    }
}