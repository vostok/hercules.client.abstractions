using System;
using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Models
{
    [PublicAPI]
    public class TimelineDescription
    {
        public TimelineDescription([NotNull] string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Unique name of the timeline which also serves as it's primary identifier.
        /// </summary>
        [NotNull]
        public string Name { get; set; }

        /// <summary>
        /// Count of slices (physical shards) in the timeline.
        /// </summary>
        public int Slices { get; set; }

        /// <summary>
        /// Storage duration for events in the timeline.
        /// </summary>
        public TimeSpan TTL { get; set; }

        /// <summary>
        /// Size of a single timetrap within a slice.
        /// </summary>
        public TimeSpan TimetrapSize { get; set; }

        /// <summary>
        /// <para>Optional list of tag keys to use when computing sharding key (order matters).</para>
        /// <para>Helps to correctly distribute events between <see cref="Slices"/>.</para>
        /// <para>Events with same tag values for these keys will end up in the same slice.</para>
        /// <para>When <c>null</c> or empty, events are distributed randomly between slices.</para>
        /// </summary>
        [CanBeNull]
        public string[] ShardingKey { get; set; }

        /// <summary>
        /// <para>Names of all streams used as data sources for this timeline.</para>
        /// </summary>
        [CanBeNull]
        public string[] Sources { get; set; }
    }
}