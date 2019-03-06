using System;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Models;

namespace Vostok.Hercules.Client.Abstractions.Queries
{
    [PublicAPI]
    public class CreateStreamQuery
    {
        /// <param name="name">Unique name of the stream. See: <see cref="Name"/>.</param>
        /// <exception cref="ArgumentNullException"><paramref name="name"/> is null.</exception>

        public CreateStreamQuery([NotNull] string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        /// <inheritdoc cref="StreamDescription.Name"/>
        [NotNull]
        public string Name { get; set; }

        /// <inheritdoc cref="StreamDescription.Type"/>
        public StreamType Type { get; set; }

        /// <inheritdoc cref="StreamDescription.Partitions"/>
        /// <remarks>If not defined, then implementation-specific default will be used.</remarks>
        public int? Partitions { get; set; }

        /// <inheritdoc cref="StreamDescription.TTL"/>
        /// <remarks>If not defined, then implementation-specific default will be used.</remarks>
        public TimeSpan? TTL { get; set; }

        /// <inheritdoc cref="StreamDescription.ShardingKey"/>
        /// <remarks>If not defined, then implementation-specific default will be used.</remarks>
        [CanBeNull]
        [ItemNotNull]
        public string[] ShardingKey { get; set; }

        /// <inheritdoc cref="StreamDescription.Sources"/>
        [CanBeNull]
        [ItemNotNull]
        public string[] Sources { get; set; }
    }
}