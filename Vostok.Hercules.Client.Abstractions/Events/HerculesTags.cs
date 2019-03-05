using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Values;

namespace Vostok.Hercules.Client.Abstractions.Events
{
    /// <summary>
    /// Represents an immutable key-value collection of tags, mapping case-sensitive string keys to <see cref="HerculesValue"/>s.
    /// </summary>
    [PublicAPI]
    public class HerculesTags : IReadOnlyDictionary<string, HerculesValue>, IEquatable<HerculesTags>
    {
        public static readonly HerculesTags Empty = new HerculesTags(new Dictionary<string, HerculesValue>());

        private readonly IReadOnlyDictionary<string, HerculesValue> tags;

        public HerculesTags([NotNull] IReadOnlyDictionary<string, HerculesValue> tags)
        {
            this.tags = tags ?? throw new ArgumentNullException(nameof(tags));
        }

        public int Count => tags.Count;

        public IEnumerable<string> Keys => tags.Keys;

        public IEnumerable<HerculesValue> Values => tags.Values;

        public bool ContainsKey([NotNull] string key)
            => tags.ContainsKey(key);

        public bool TryGetValue(string key, out HerculesValue value)
            => tags.TryGetValue(key, out value);

        public IEnumerator<KeyValuePair<string, HerculesValue>> GetEnumerator()
            => tags.GetEnumerator();

        /// <summary>
        /// <para>Returns the value of tag with given <paramref name="key"/>.</para>
        /// <para>Throws a <see cref="KeyNotFoundException"/> if no such tag exists.</para>
        /// </summary>
        [NotNull]
        public HerculesValue GetValue([NotNull] string key)
            => tags.TryGetValue(key, out var value) ? value : throw new KeyNotFoundException($"Tag with name '{key}' does not exist in this Hercules container.");

        /// <summary>
        /// <para>Returns the value of tag with given <paramref name="key"/> or <c>null</c> if no such tag exists.</para>
        /// <para>Does not throw exceptions.</para>
        /// </summary>
        [CanBeNull]
        public HerculesValue this[[NotNull] string key]
            => tags.TryGetValue(key, out var value) ? value : null;

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        #region Equality

        public bool Equals(HerculesTags other)
        {
            if (other == null)
                return false;

            if (ReferenceEquals(this, other))
                return true;

            if (tags.Count != other.tags.Count)
                return false;

            foreach (var pair in tags)
            {
                if (!other.tags.TryGetValue(pair.Key, out var otherValue) || !Equals(pair.Value, otherValue))
                    return false;
            }

            return true;
        }

        public override bool Equals(object other)
            => Equals(other as HerculesTags);

        public override int GetHashCode()
        {
            unchecked
            {
                int HashPair(KeyValuePair<string, HerculesValue> pair)
                    => ((pair.Key?.GetHashCode() ?? 0) * 397) ^ (pair.Value?.GetHashCode() ?? 0);

                return tags.Aggregate(tags.Count, (current, element) => current ^ HashPair(element));
            }
        }

        #endregion
    }
}
