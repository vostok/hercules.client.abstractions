using System;
using JetBrains.Annotations;

// ReSharper disable NonReadonlyMemberInGetHashCode

namespace Vostok.Hercules.Client.Abstractions.Models
{
    /// <summary>
    /// Represents reader's position inside a single partition of a stream.
    /// </summary>
    [PublicAPI]
    public struct StreamPosition : IEquatable<StreamPosition>
    {
        /// <summary>
        /// Zero-based partition index.
        /// </summary>
        public int Partition;

        /// <summary>
        /// Event offset inside the partition.
        /// </summary>
        public long Offset;

        public override string ToString() => $"{Partition} --> {Offset}";

        #region Equality

        public bool Equals(StreamPosition other)
            => Partition == other.Partition && Offset == other.Offset;

        public override bool Equals(object obj)
            => obj is StreamPosition other && Equals(other);

        public override int GetHashCode()
        {
            unchecked
            {
                return (Partition * 397) ^ Offset.GetHashCode();
            }
        }

        #endregion
    }
}