using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using Vostok.Commons.Collections;
using Vostok.Hercules.Client.Abstractions.Values;

namespace Vostok.Hercules.Client.Abstractions.Events
{
    [PublicAPI]
    public partial class HerculesTagsBuilder : IHerculesTagsBuilder
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

        public IHerculesTagsBuilder AddContainer(string key, Action<IHerculesTagsBuilder> valueBuilder)
            => AddValueGeneric(key, BuildContainer(valueBuilder));

        public IHerculesTagsBuilder AddVectorOfContainers(string key, IReadOnlyList<Action<IHerculesTagsBuilder>> valueBuilders)
            => AddVectorGeneric(key, valueBuilders.Select(BuildContainer).ToArray());

        public IHerculesTagsBuilder AddNull(string key)
            => AddValueGeneric(key, HerculesNull.Instance);

        public IHerculesTagsBuilder RemoveTags(string key)
            => Remove(key);

        private static HerculesTags BuildContainer(Action<IHerculesTagsBuilder> valueBuilder)
        {
            var internalTagsBuilder = new HerculesTagsBuilder();

            valueBuilder(internalTagsBuilder);

            return internalTagsBuilder.BuildTags();
        }

        private IHerculesTagsBuilder AddValueGeneric<T>(string key, T value)
            => Set(key, new HerculesValue<T>(value));

        private IHerculesTagsBuilder AddVectorGeneric<T>(string key, IReadOnlyList<T> values)
            => Set(key, new HerculesValue<HerculesVector>(new HerculesVector<T>(values)));

        private HerculesTagsBuilder Set(string key, HerculesValue value)
        {
            tags = tags.Set(key, value);

            return this;
        }

        private HerculesTagsBuilder Remove(string key)
        {
            tags = tags.Remove(key);

            return this;
        }
    }
}
