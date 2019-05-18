using System;
using JetBrains.Annotations;
using Vostok.Commons.Helpers.Comparers;

namespace Vostok.Hercules.Client.Abstractions.Models
{
    /// <summary>
    /// Represents reader's position in a timeline.
    /// </summary>
    [PublicAPI]
    public class TimelineCoordinates : IEquatable<TimelineCoordinates>
    {
        public static readonly TimelineCoordinates Empty = new TimelineCoordinates(new TimelinePosition[] {});

        public TimelineCoordinates([NotNull] TimelinePosition[] positions)
            => Positions = positions ?? throw new ArgumentNullException(nameof(positions));

        /// <summary>
        /// Positions in all known slices.
        /// </summary>
        [NotNull]
        public TimelinePosition[] Positions { get; }

        #region Equality

        public bool Equals(TimelineCoordinates other)
            => ListComparer<TimelinePosition>.Instance.Equals(Positions, other?.Positions);

        public override bool Equals(object obj)
            => Equals(obj as TimelineCoordinates);

        public override int GetHashCode()
            => ListComparer<TimelinePosition>.Instance.GetHashCode(Positions);

        #endregion
    }
}