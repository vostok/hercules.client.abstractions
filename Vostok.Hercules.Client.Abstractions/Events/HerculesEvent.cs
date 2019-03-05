using System;
using System.Text;
using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Events
{
    /// <summary>
    /// <para>Represents a single event in Hercules: an atomic unit of data exchange.</para>
    /// <para>Every event consists of a <see cref="Timestamp"/> and a collection of <see cref="Tags"/> (see <see cref="HerculesTags"/> for more info).</para>
    /// </summary>
    [PublicAPI]
    public class HerculesEvent : IEquatable<HerculesEvent>
    {
        public HerculesEvent(DateTimeOffset timestamp, [NotNull] HerculesTags tags)
        {
            Timestamp = timestamp;
            Tags = tags ?? throw new ArgumentNullException(nameof(tags));
        }

        public DateTimeOffset Timestamp { get; }

        [NotNull]
        public HerculesTags Tags { get; }

        #region ToString

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.Append("Timestamp: ");
            builder.AppendLine(Timestamp.ToString("u"));
            builder.Append("Tags: ");

            if (Tags.Count == 0)
            {
                builder.Append("{}");
            }
            else
            {
                builder.AppendLine();
                builder.Append(HerculesTagsRenderer.Render(Tags));
            }

            return builder.ToString();
        } 

        #endregion

        #region Equality

        public bool Equals(HerculesEvent other)
        {
            if (other == null)
                return false;

            if (ReferenceEquals(this, other))
                return true;

            return Timestamp.UtcTicks == other.Timestamp.UtcTicks && Tags.Equals(other.Tags);
        }

        public override bool Equals(object other)
            => Equals(other as HerculesEvent);

        public override int GetHashCode()
        {
            unchecked
            {
                return (Timestamp.UtcTicks.GetHashCode() * 397) ^ Tags.GetHashCode();
            }
        }

        #endregion
    }
}
