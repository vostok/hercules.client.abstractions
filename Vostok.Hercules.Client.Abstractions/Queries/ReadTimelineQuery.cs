using System;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Models;
using Vostok.Hercules.Client.Abstractions.Results;

namespace Vostok.Hercules.Client.Abstractions.Queries
{
    [PublicAPI]
    public class ReadTimelineQuery
    {
        public ReadTimelineQuery([NotNull] string name)
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
        /// Limit on how many events this query may return.
        /// </summary>
        public int Limit { get; set; } = 10 * 1000;

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

        /// <summary>
        /// <para>Starting coordinates in the queried range.</para>
        /// <para><see cref="TimelineCoordinates.Empty"/> by default (start from the beginning of queried interval).</para>
        /// <para>Use this state to resume a previous read by passing a value obtained from <see cref="HerculesTimelineReadResult"/>.</para>
        /// <para>Don't use it instead of <see cref="From"/> and <see cref="To"/> to express ranges.</para>
        /// </summary>
        public TimelineCoordinates Coordinates { get; set; } = TimelineCoordinates.Empty;
    }
}