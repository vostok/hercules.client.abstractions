using System;
using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Queries
{
    [PublicAPI]
    public class ScanTimelineQuery
    {
        public ScanTimelineQuery([NotNull] string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Name of timeline to read from.
        /// </summary>
        [NotNull]
        public string Name { get; set; }

        /// <summary>
        /// Left inclusive bound of the queried time range.
        /// </summary>
        public DateTimeOffset From { get; set; } = DateTimeOffset.MinValue;

        /// <summary>
        /// Right exclusive bound of the queried time range.
        /// </summary>
        public DateTimeOffset To { get; set; } = DateTimeOffset.MinValue;

        /// <summary>
        /// An upper bound on how many events can be requested with a single read.
        /// </summary>
        public int BatchSize { get; set; } = 10 * 1000;

        /// <summary>
        /// <para>Zero-based index of the client-side virtual shard.</para>
        /// <para>These shards are mapped into actual physical shards by Hercules.</para>
        /// </summary>
        public int ClientShard { get; set; }

        /// <summary>
        /// <para>Count of client-side virtual shards.</para>
        /// <para>These shards are mapped into actual physical shards by Hercules.</para>
        /// </summary>
        public int ClientShardCount { get; set; } = 1;
    }
}