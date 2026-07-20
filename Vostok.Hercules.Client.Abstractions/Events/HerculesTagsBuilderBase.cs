using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Values;

namespace Vostok.Hercules.Client.Abstractions.Events
{
    [PublicAPI]
    public abstract partial class HerculesTagsBuilderBase
    {
        public IHerculesTagsBuilder AddContainer(string key, Action<IHerculesTagsBuilder> valueBuilder)
            => AddValueGeneric(key, BuildContainer(valueBuilder));

        public IHerculesTagsBuilder AddVectorOfContainers(string key, IReadOnlyList<Action<IHerculesTagsBuilder>> valueBuilders)
            => AddVectorGeneric(key, valueBuilders.Select(BuildContainer).ToArray());

        public IHerculesTagsBuilder AddVectorOfContainers<TValue>(string key, IReadOnlyList<TValue> values, Action<IHerculesTagsBuilder, TValue> valueBuilder)
        {
            //(deniaa): This is not the place for LINQ and unnecessary closures, keep your hands off alt+enter.
            var list = new List<HerculesTags>(values.Count);
            foreach (var v in values)
                list.Add(BuildContainer(v, valueBuilder));

            return AddVectorGeneric(key, list);
        }

        public IHerculesTagsBuilder AddNull(string key)
            => AddValueGeneric(key, HerculesNull.Instance);

        public IHerculesTagsBuilder RemoveTags(string key)
            => Remove(key);
        
        protected abstract HerculesTags BuildContainer<TValue>(TValue value, Action<IHerculesTagsBuilder, TValue> valueBuilder);
        protected abstract HerculesTags BuildContainer(Action<IHerculesTagsBuilder> valueBuilder);
        
        private IHerculesTagsBuilder AddValueGeneric<T>(string key, T value)
            => Set(key, new HerculesValue<T>(value));

        private IHerculesTagsBuilder AddVectorGeneric<T>(string key, IReadOnlyList<T> values)
            => Set(key, new HerculesValue<HerculesVector>(new HerculesVector<T>(values)));

        internal abstract IHerculesTagsBuilder Set(string key, HerculesValue value);
        internal abstract IHerculesTagsBuilder Remove(string key);
    }
}