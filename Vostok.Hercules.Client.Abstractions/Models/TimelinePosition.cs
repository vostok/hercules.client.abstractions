using System;
using JetBrains.Annotations;
using Vostok.Commons.Helpers.Comparers;

// ReSharper disable NonReadonlyMemberInGetHashCode

namespace Vostok.Hercules.Client.Abstractions.Models
{
    /// <summary>
    /// Represents reader's position inside a single slice of a timeline.
    /// </summary>
    [PublicAPI]
    public struct TimelinePosition : IEquatable<TimelinePosition>
    {
        /// <summary>
        /// Zero-based slice index.
        /// </summary>
        public int Slice;

        /// <summary>
        /// Event offset inside the slice.
        /// </summary>
        public long Offset;

        /// <summary>
        /// Id of the last read event (used to resolve timestamp collisions).
        /// </summary>
        public byte[] EventId;

        #region Equality

        public bool Equals(TimelinePosition other) =>
            Slice == other.Slice && Offset == other.Offset && ListComparer<byte>.Instance.Equals(EventId, other.EventId);

        public override bool Equals(object obj)
            => obj is TimelinePosition other && Equals(other);

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Slice;
                hashCode = (hashCode * 397) ^ Offset.GetHashCode();
                hashCode = (hashCode * 397) ^ ListComparer<byte>.Instance.GetHashCode(EventId);
                return hashCode;
            }
        }

        #endregion
    }
}