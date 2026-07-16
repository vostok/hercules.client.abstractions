using System.Collections.Generic;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Values;

namespace Vostok.Hercules.Client.Abstractions.Events
{
    [PublicAPI]
    public class HerculesTagsBuilderUnsafe : HerculesTagsBuilderBase, IHerculesTagsBuilder
    {
        private Dictionary<string, HerculesValue> tags = new();

        public HerculesTagsBuilderUnsafe()
        {
        }

        public HerculesTagsBuilderUnsafe(HerculesTags startingTags)
        {
            foreach (var pair in startingTags)
                Set(pair.Key, pair.Value);
        }

        public HerculesTags BuildTags() => new HerculesTags(tags);

        internal sealed override IHerculesTagsBuilder Set(string key, HerculesValue value)
        {
            tags[key] = value;

            return this;
        }

        internal sealed override IHerculesTagsBuilder Remove(string key)
        {
            tags.Remove(key);

            return this;
        }
    }
}