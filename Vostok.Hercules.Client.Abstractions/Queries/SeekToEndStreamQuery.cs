using System;
using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Queries
{
    [PublicAPI]
    public class SeekToEndStreamQuery
    {
        public SeekToEndStreamQuery([NotNull] string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Name of the stream to read from.
        /// </summary>
        [NotNull]
        public string Name { get; }

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