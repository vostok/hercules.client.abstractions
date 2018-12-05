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
        private ImmutableArrayDictionary<string, HerculesValue> tags
            = ImmutableArrayDictionary<string, HerculesValue>.Empty;

        public HerculesTags BuildTags() => new HerculesTags(tags);

        public IHerculesTagsBuilder AddValue(string key, byte value) => AddValueGeneric(key, value);

        public IHerculesTagsBuilder AddValue(string key, short value) => AddValueGeneric(key, value);

        public IHerculesTagsBuilder AddValue(string key, int value) => AddValueGeneric(key, value);

        public IHerculesTagsBuilder AddValue(string key, long value) => AddValueGeneric(key, value);

        public IHerculesTagsBuilder AddValue(string key, bool value) => AddValueGeneric(key, value);

        public IHerculesTagsBuilder AddValue(string key, float value) => AddValueGeneric(key, value);

        public IHerculesTagsBuilder AddValue(string key, double value) => AddValueGeneric(key, value);

        public IHerculesTagsBuilder AddValue(string key, Guid value) => AddValueGeneric(key, value);

        public IHerculesTagsBuilder AddValue(string key, string value) => AddValueGeneric(key, value);

        public IHerculesTagsBuilder AddVector(string key, IReadOnlyList<byte> values) => AddVectorGeneric(key, values);

        public IHerculesTagsBuilder AddVector(string key, IReadOnlyList<short> values) => AddVectorGeneric(key, values);

        public IHerculesTagsBuilder AddVector(string key, IReadOnlyList<int> values) => AddVectorGeneric(key, values);

        public IHerculesTagsBuilder AddVector(string key, IReadOnlyList<long> values) => AddVectorGeneric(key, values);

        public IHerculesTagsBuilder AddVector(string key, IReadOnlyList<bool> values) => AddVectorGeneric(key, values);

        public IHerculesTagsBuilder AddVector(string key, IReadOnlyList<float> values) => AddVectorGeneric(key, values);

        public IHerculesTagsBuilder AddVector(string key, IReadOnlyList<double> values) => AddVectorGeneric(key, values);

        public IHerculesTagsBuilder AddVector(string key, IReadOnlyList<Guid> values) => AddVectorGeneric(key, values);

        public IHerculesTagsBuilder AddVector(string key, IReadOnlyList<string> values) => AddVectorGeneric(key, values);

        public IHerculesTagsBuilder AddContainer(string key, Action<IHerculesTagsBuilder> valueBuilder) 
            => Set(key, BuildContainer(valueBuilder));

        public IHerculesTagsBuilder AddVectorOfContainers(string key, IReadOnlyList<Action<IHerculesTagsBuilder>> valueBuilders)
            => AddVectorGeneric(key, valueBuilders.Select(x => BuildContainer(x)).ToArray());

        private IHerculesTagsBuilder AddValueGeneric<T>(string key, T value) 
            => Set(key, new HerculesValue<T>(value));
        
        private static HerculesValue<HerculesTags> BuildContainer(Action<IHerculesTagsBuilder> valueBuilder)
        {
            var internalTagsBuilder = new HerculesTagsBuilder();

            valueBuilder(internalTagsBuilder);

            return new HerculesValue<HerculesTags>(internalTagsBuilder.BuildTags());
        }

        private HerculesTagsBuilder Set(string key, HerculesValue value)
        {
            tags = tags.Set(key, value);

            return this;
        }

        private IHerculesTagsBuilder AddVectorGeneric<T>(string key, IReadOnlyList<T> values)
        {
            var array = new T[values.Count];
            
            for (var i = 0; i < array.Length; i++)
                array[i] = values[i];
            
            return Set(key, new HerculesValue<HerculesVector>(new HerculesVector<T>(array)));
        }
    }
}
