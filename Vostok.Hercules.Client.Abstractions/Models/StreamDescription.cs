using System;
using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Models
{
    [PublicAPI]
    public class StreamDescription
    {
        public StreamDescription([NotNull] string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Unique name of the stream which also serves as it's primary identifier.
        /// </summary>
        [NotNull]
        public string Name { get; set; }

        /// <summary>
        /// Type of the stream (<see cref="StreamType.Base"/> or <see cref="StreamType.Derived"/>).
        /// </summary>
        public StreamType Type { get; set; }

        /// <summary>
        /// Count of partitions (physical shards) in the stream.
        /// </summary>
        public int Partitions { get; set; }

        /// <summary>
        /// Storage duration for events in the stream.
        /// </summary>
        public TimeSpan TTL { get; set; }

        /// <summary>
        /// <para>Optional list of tag keys to use when computing sharding key (order matters).</para>
        /// <para>Helps to correctly distribute events between <see cref="Partitions"/>.</para>
        /// <para>Events with same tag values for these keys will end up in the same partition.</para>
        /// <para>When <c>null</c> or empty, events are distributed randomly between partitions.</para>
        /// </summary>
        [CanBeNull]
        [ItemNotNull]
        public string[] ShardingKey { get; set; }

        /// <summary>
        /// <para>Names of all streams used as data sources for this stream.</para>
        /// <para>Only relevant for <see cref="StreamType.Derived"/> streams.</para>
        /// </summary>
        [CanBeNull]
        [ItemNotNull]
        public string[] Sources { get; set; }
    }
}