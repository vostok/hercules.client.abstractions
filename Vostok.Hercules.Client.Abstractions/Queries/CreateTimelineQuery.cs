using System;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Models;

namespace Vostok.Hercules.Client.Abstractions.Queries
{
    [PublicAPI]
    public class CreateTimelineQuery
    {
        /// <param name="name">Unique name of the timeline. See: <see cref="Name"/>.</param>
        /// <param name="sources">Names of all streams used as data sources for this timeline. Timeline should have at least one source stream.</param>
        /// <exception cref="ArgumentNullException"><paramref name="name"/> or <paramref name="sources"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="sources"/> is empty.</exception>
        public CreateTimelineQuery([NotNull] string name, [NotNull] [ItemNotNull] string[] sources)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Sources = sources ?? throw new ArgumentNullException(nameof(sources));

            if (sources.Length == 0)
                throw new ArgumentException("Sources array is empty. At least one source stream should be provided.", nameof(sources));
        }

        /// <inheritdoc cref="TimelineDescription.Name"/>
        [NotNull]
        public string Name { get; }

        /// <inheritdoc cref="TimelineDescription.Sources"/>
        [NotNull]
        [ItemNotNull]
        public string[] Sources { get; }

        /// <inheritdoc cref="TimelineDescription.Slices"/>
        /// <remarks>If not defined, implementation-specific default will be used.</remarks>
        public int? Slices { get; set; }

        /// <inheritdoc cref="TimelineDescription.TTL"/>
        /// <remarks>If not defined, implementation-specific default will be used.</remarks>
        public TimeSpan? TTL { get; set; }

        /// <inheritdoc cref="TimelineDescription.TimetrapSize"/>
        /// <remarks>If not defined, implementation-specific default will be used.</remarks>
        public TimeSpan? TimetrapSize { get; set; }

        /// <inheritdoc cref="TimelineDescription.ShardingKey"/>
        [CanBeNull]
        [ItemNotNull]
        public string[] ShardingKey { get; set; }
    }
}