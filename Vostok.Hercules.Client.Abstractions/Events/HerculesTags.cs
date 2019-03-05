using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Values;

namespace Vostok.Hercules.Client.Abstractions.Events
{
    /// <summary>
    /// Represents an immutable key-value collection of tags, mapping case-sensitive string keys to <see cref="HerculesValue"/>s.
    /// </summary>
    [PublicAPI]
    public class HerculesTags : IReadOnlyDictionary<string, HerculesValue>
    {
        public static readonly HerculesTags Empty = new HerculesTags(new Dictionary<string, HerculesValue>());

        private readonly IReadOnlyDictionary<string, HerculesValue> tags;

        public HerculesTags([NotNull] IReadOnlyDictionary<string, HerculesValue> tags)
        {
            this.tags = tags;
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
    }
}
