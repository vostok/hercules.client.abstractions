using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using Vostok.Commons.Collections;
using Vostok.Hercules.Client.Abstractions.Values;

namespace Vostok.Hercules.Client.Abstractions.Events
{
    [PublicAPI]
    public class HerculesTagsBuilder : IHerculesTagsBuilder
    {
        private ImmutableArrayDictionary<string, HerculesValue> tags = ImmutableArrayDictionary<string, HerculesValue>.Empty;

        public HerculesTags BuildTags() => new HerculesTags(tags);

        public IHerculesTagsBuilder AddValue(string key, byte value) 
            => Set(key, new HerculesByte(value));

        public IHerculesTagsBuilder AddValue(string key, short value) 
            => Set(key, new HerculesShort(value));

        public IHerculesTagsBuilder AddValue(string key, int value) 
            => Set(key, new HerculesInt(value));

        public IHerculesTagsBuilder AddValue(string key, long value)
            => Set(key, new HerculesLong(value));

        public IHerculesTagsBuilder AddValue(string key, bool value) 
            => Set(key, new HerculesBool(value));

        public IHerculesTagsBuilder AddValue(string key, float value) 
            => Set(key, new HerculesFloat(value));

        public IHerculesTagsBuilder AddValue(string key, double value) 
            => Set(key, new HerculesDouble(value));

        public IHerculesTagsBuilder AddValue(string key, Guid value) 
            => Set(key, new HerculesGuid(value));

        public IHerculesTagsBuilder AddValue(string key, string value) 
            => Set(key, new HerculesString(value));

        public IHerculesTagsBuilder AddArray(string key, IList<byte> values)
        //TODO: use size
            => Set(key, new HerculesArray(values.Select(v => new HerculesByte(v) as HerculesValue).ToArray()));

        public IHerculesTagsBuilder AddArray(string key, IList<short> values)
            => Set(key, new HerculesArray(values.Select(v => new HerculesShort(v) as HerculesValue).ToArray()));

        public IHerculesTagsBuilder AddArray(string key, IList<int> values)
            => Set(key, new HerculesArray(values.Select(v => new HerculesInt(v) as HerculesValue).ToArray()));

        public IHerculesTagsBuilder AddArray(string key, IList<long> values)
            => Set(key, new HerculesArray(values.Select(v => new HerculesLong(v) as HerculesValue).ToArray()));

        public IHerculesTagsBuilder AddArray(string key, IList<bool> values)
            => Set(key, new HerculesArray(values.Select(v => new HerculesBool(v) as HerculesValue).ToArray()));

        public IHerculesTagsBuilder AddArray(string key, IList<float> values)
            => Set(key, new HerculesArray(values.Select(v => new HerculesFloat(v) as HerculesValue).ToArray()));

        public IHerculesTagsBuilder AddArray(string key, IList<double> values)
            => Set(key, new HerculesArray(values.Select(v => new HerculesDouble(v) as HerculesValue).ToArray()));

        public IHerculesTagsBuilder AddArray(string key, IList<Guid> values)
            => Set(key, new HerculesArray(values.Select(v => new HerculesGuid(v) as HerculesValue).ToArray()));

        public IHerculesTagsBuilder AddArray(string key, IList<string> values)
            => Set(key, new HerculesArray(values.Select(v => new HerculesString(v) as HerculesValue).ToArray()));

        public IHerculesTagsBuilder AddContainer(string key, Action<IHerculesTagsBuilder> valueBuilder) 
            => Set(key, BuildContainer(valueBuilder));

        public IHerculesTagsBuilder AddArrayOfContainers(string key, IEnumerable<Action<IHerculesTagsBuilder>> valueBuilders)
            => Set(key, new HerculesArray(valueBuilders.Select(b => BuildContainer(b) as HerculesValue).ToArray()));

        private static HerculesContainer BuildContainer(Action<IHerculesTagsBuilder> valueBuilder)
        {
            var internalTagsBuilder = new HerculesTagsBuilder();

            valueBuilder(internalTagsBuilder);

            return new HerculesContainer(internalTagsBuilder.BuildTags());
        }

        private HerculesTagsBuilder Set(string key, HerculesValue value)
        {
            tags = tags.Set(key, value);

            return this;
        }
    }
}
