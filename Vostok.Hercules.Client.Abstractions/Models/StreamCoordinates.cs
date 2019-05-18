using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using Vostok.Commons.Helpers.Comparers;

namespace Vostok.Hercules.Client.Abstractions.Models
{
    /// <summary>
    /// Represents reader's position in a stream.
    /// </summary>
    [PublicAPI]
    public class StreamCoordinates : IEquatable<StreamCoordinates>
    {
        public static readonly StreamCoordinates Empty = new StreamCoordinates(new StreamPosition[] {});

        public StreamCoordinates([NotNull] StreamPosition[] positions)
            => Positions = positions ?? throw new ArgumentNullException(nameof(positions));

        /// <summary>
        /// Positions in all known partitions.
        /// </summary>
        [NotNull]
        public StreamPosition[] Positions { get; }

        /// <summary>
        /// Returns <see cref="Positions"/> organized as a dictionary keyed by stream partition index.
        /// </summary>
        [NotNull]
        public Dictionary<int, StreamPosition> ToDictionary()
            => Positions.ToDictionary(position => position.Partition, position => position);

        public override string ToString() => string.Join("; ", Positions);

        #region Equality

        public bool Equals(StreamCoordinates other)
            => ListComparer<StreamPosition>.Instance.Equals(Positions, other?.Positions);

        public override bool Equals(object obj)
            => Equals(obj as StreamCoordinates);

        public override int GetHashCode()
            => ListComparer<StreamPosition>.Instance.GetHashCode(Positions);

        #endregion
    }
}
