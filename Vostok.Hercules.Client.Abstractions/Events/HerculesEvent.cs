using System;
using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Events
{
    /// <summary>
    /// <para>Represents a single event in Hercules: an atomic unit of data exchange.</para>
    /// <para>Every event consists of a <see cref="Timestamp"/> and a collection of <see cref="Tags"/> (see <see cref="HerculesTags"/> for more info).</para>
    /// </summary>
    [PublicAPI]
    public class HerculesEvent
    {
        public HerculesEvent(DateTimeOffset timestamp, [NotNull] HerculesTags tags)
        {
            Timestamp = timestamp;
            Tags = tags ?? throw new ArgumentNullException(nameof(tags));
        }

        public DateTimeOffset Timestamp { get; }

        [NotNull]
        public HerculesTags Tags { get; }
    }
}