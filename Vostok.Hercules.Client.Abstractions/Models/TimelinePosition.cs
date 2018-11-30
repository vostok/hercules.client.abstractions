using System;
using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Models
{
    /// <summary>
    /// Represents reader's position inside a single slice of a timeline.
    /// </summary>
    [PublicAPI]
    public struct TimelinePosition
    {
        /// <summary>
        /// Zero-based slice index.
        /// </summary>
        public int Slice;

        /// <summary>
        /// Event offset inside the slice.
        /// </summary>
        public DateTimeOffset Offset;

        /// <summary>
        /// Id of the last read event (used to resolve timestamp collisions).
        /// </summary>
        public string EventId;
    }
}