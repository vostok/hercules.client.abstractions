using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Models
{
    /// <summary>
    /// Represents reader's position in a stream.
    /// </summary>
    [PublicAPI]
    public class StreamCoordinates
    {
        public static readonly StreamCoordinates Empty = new StreamCoordinates(new StreamPosition[] {});

        public StreamCoordinates([NotNull] StreamPosition[] positions)
        {
            Positions = positions;
        }

        /// <summary>
        /// Positions in all known partitions.
        /// </summary>
        [NotNull]
        public StreamPosition[] Positions { get; }
    }
}