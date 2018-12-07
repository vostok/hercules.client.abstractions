using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Models
{
    /// <summary>
    /// Represents reader's position in a timeline.
    /// </summary>
    [PublicAPI]
    public class TimelineCoordinates
    {
        public static readonly TimelineCoordinates Empty = new TimelineCoordinates(new TimelinePosition[] { });

        public TimelineCoordinates([NotNull] TimelinePosition[] positions)
        {
            Positions = positions;
        }

        /// <summary>
        /// Positions in all known slices.
        /// </summary>
        [NotNull]
        public TimelinePosition[] Positions { get; }
    }
}