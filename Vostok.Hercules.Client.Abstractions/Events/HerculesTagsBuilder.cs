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

        public HerculesTags BuildTags() => new HerculesTags(tags);

        public IHerculesTagsBuilder AddContainer(string key, Action<IHerculesTagsBuilder> valueBuilder) 
            => AddValueGeneric(key, BuildContainer(valueBuilder));

        public IHerculesTagsBuilder AddVectorOfContainers(string key, IReadOnlyList<Action<IHerculesTagsBuilder>> valueBuilders)
            => AddVectorGeneric(key, valueBuilders.Select(x => BuildContainer(x)).ToArray());

        private IHerculesTagsBuilder AddValueGeneric<T>(string key, T value) 
            => Set(key, new HerculesValue<T>(value));
        
        private static HerculesTags BuildContainer(Action<IHerculesTagsBuilder> valueBuilder)
        {
            var internalTagsBuilder = new HerculesTagsBuilder();

            valueBuilder(internalTagsBuilder);

            return internalTagsBuilder.BuildTags();
        }

        private HerculesTagsBuilder Set(string key, HerculesValue value)
        {
            tags = tags.Set(key, value);

            return this;
        }

        private IHerculesTagsBuilder AddVectorGeneric<T>(string key, IReadOnlyList<T> values)
        {
            if (values is T[] arr)
                return AddVectorGeneric(key, arr);
                
            var array = new T[values.Count];
            
            for (var i = 0; i < array.Length; i++)
                array[i] = values[i];
            
            return Set(key, new HerculesValue<HerculesVector>(new HerculesVector<T>(array)));
        }
        
        private IHerculesTagsBuilder AddVectorGeneric<T>(string key, T[] values)
        {
            var array = new T[values.Length];
            
            Array.Copy(values, 0, array, 0, values.Length);
            
            return Set(key, new HerculesValue<HerculesVector>(new HerculesVector<T>(array)));
        }
    }
}
