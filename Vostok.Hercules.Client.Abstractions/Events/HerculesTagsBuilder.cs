using System;
using JetBrains.Annotations;
using Vostok.Commons.Collections;
using Vostok.Hercules.Client.Abstractions.Values;

namespace Vostok.Hercules.Client.Abstractions.Events
{
    [PublicAPI]
    public class HerculesTagsBuilder : HerculesTagsBuilderBase, IHerculesTagsBuilder
    {
        private ImmutableArrayDictionary<string, HerculesValue> tags
            = ImmutableArrayDictionary<string, HerculesValue>.Empty;

        public HerculesTagsBuilder()
        {
        }

        public HerculesTagsBuilder(HerculesTags startingTags)
        {
            foreach (var pair in startingTags)
                Set(pair.Key, pair.Value);
        }

        public HerculesTags BuildTags() => new HerculesTags(tags);

        internal sealed override IHerculesTagsBuilder Set(string key, HerculesValue value)
        {
            tags = tags.Set(key, value);

            return this;
        }

        internal sealed override IHerculesTagsBuilder Remove(string key)
        {
            tags = tags.Remove(key);

            return this;
        }
        
        protected override HerculesTags BuildContainer(Action<IHerculesTagsBuilder> valueBuilder)
        {
            var internalTagsBuilder = new HerculesTagsBuilder();

            valueBuilder(internalTagsBuilder);

            return internalTagsBuilder.BuildTags();
        }
        protected override HerculesTags BuildContainer<TValue>(TValue value, Action<IHerculesTagsBuilder, TValue> valueBuilder)
        {
            var internalTagsBuilder = new HerculesTagsBuilder();

            valueBuilder(internalTagsBuilder, value);

            return internalTagsBuilder.BuildTags();
        }
    }
}