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

        public IHerculesTagsBuilder AddVector(string key, IReadOnlyList<byte> values)
            => AddVector(key, values, HerculesValueType.Byte, x => new HerculesByte(x));

        public IHerculesTagsBuilder AddVector(string key, IReadOnlyList<short> values)
            => AddVector(key, values, HerculesValueType.Short, x => new HerculesShort(x));

        public IHerculesTagsBuilder AddVector(string key, IReadOnlyList<int> values)
            => AddVector(key, values, HerculesValueType.Int, x => new HerculesInt(x));

        public IHerculesTagsBuilder AddVector(string key, IReadOnlyList<long> values)
            => AddVector(key, values, HerculesValueType.Long, x => new HerculesLong(x));

        public IHerculesTagsBuilder AddVector(string key, IReadOnlyList<bool> values)
            => AddVector(key, values, HerculesValueType.Bool, x => new HerculesBool(x));

        public IHerculesTagsBuilder AddVector(string key, IReadOnlyList<float> values)
            => AddVector(key, values, HerculesValueType.Float, x => new HerculesFloat(x));

        public IHerculesTagsBuilder AddVector(string key, IReadOnlyList<double> values)
            => AddVector(key, values, HerculesValueType.Double, x => new HerculesDouble(x));

        public IHerculesTagsBuilder AddVector(string key, IReadOnlyList<Guid> values)
            => AddVector(key, values, HerculesValueType.Guid, x => new HerculesGuid(x));

        public IHerculesTagsBuilder AddVector(string key, IReadOnlyList<string> values)
            => AddVector(key, values, HerculesValueType.String, x => new HerculesString(x));

        public IHerculesTagsBuilder AddContainer(string key, Action<IHerculesTagsBuilder> valueBuilder) 
            => Set(key, BuildContainer(valueBuilder));

        public IHerculesTagsBuilder AddVectorOfContainers(string key, IReadOnlyList<Action<IHerculesTagsBuilder>> valueBuilders)
            => AddVector(key, valueBuilders, HerculesValueType.Container, x => BuildContainer(x));

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

        private IHerculesTagsBuilder AddVector<T>(string key, IReadOnlyList<T> values, HerculesValueType type, Func<T, HerculesValue> toHerculesValue)
        {
            var array = new HerculesValue[values.Count];
            
            for (var i = 0; i < array.Length; i++)
                array[i] = toHerculesValue(values[i]);
            
            return Set(key, new HerculesVector(array, type));
        }
    }
}
