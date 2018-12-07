using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Models
{
    /// <summary>
    /// Represents reader's position inside a single partition of a stream.
    /// </summary>
    [PublicAPI]
    public struct StreamPosition
    {
        /// <summary>
        /// Zero-based partition index.
        /// </summary>
        public int Partition;

        /// <summary>
        /// Event offset inside the partition.
        /// </summary>
        public long Offset;
    }
}