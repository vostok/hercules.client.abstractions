using System;
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