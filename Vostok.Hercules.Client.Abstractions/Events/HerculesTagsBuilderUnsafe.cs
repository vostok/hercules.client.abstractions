using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Values;

namespace Vostok.Hercules.Client.Abstractions.Events
{
    [PublicAPI]
    public class HerculesTagsBuilderUnsafe : HerculesTagsBuilderBase, IHerculesTagsBuilder
    {
        private Dictionary<string, HerculesValue> tags;

        public HerculesTagsBuilderUnsafe(int initialCapacity)
        {
            tags = new Dictionary<string, HerculesValue>(initialCapacity);
        }

        public HerculesTagsBuilderUnsafe()
        {
            tags  = new Dictionary<string, HerculesValue>();
        }

        public HerculesTagsBuilderUnsafe(HerculesTags startingTags)
        {
            tags = new Dictionary<string, HerculesValue>(startingTags.Count);
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
        
        protected override HerculesTags BuildContainer(Action<IHerculesTagsBuilder> valueBuilder)
        {
            var internalTagsBuilder = new HerculesTagsBuilderUnsafe();

            valueBuilder(internalTagsBuilder);

            return internalTagsBuilder.BuildTags();
        }
        protected override HerculesTags BuildContainer<TValue>(TValue value, Action<IHerculesTagsBuilder, TValue> valueBuilder)
        {
            var internalTagsBuilder = new HerculesTagsBuilderUnsafe();

            valueBuilder(internalTagsBuilder, value);

            return internalTagsBuilder.BuildTags();
        }
    }
}