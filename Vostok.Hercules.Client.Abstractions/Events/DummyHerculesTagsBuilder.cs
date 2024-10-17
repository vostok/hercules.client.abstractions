using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Events
{
    [PublicAPI]
    public partial class DummyHerculesTagsBuilder : IHerculesTagsBuilder
    {
        public IHerculesTagsBuilder AddContainer(string key, Action<IHerculesTagsBuilder> valueBuilder)
        {
            valueBuilder(this);
            return this;
        }

        public IHerculesTagsBuilder AddVectorOfContainers(string key, IReadOnlyList<Action<IHerculesTagsBuilder>> valueBuilders)
        {
            foreach (var valueBuilder in valueBuilders)
            {
                valueBuilder(this);
            }

            return this;
        }

        public IHerculesTagsBuilder AddVectorOfContainers<TValue>(string key, IReadOnlyList<TValue> values, Action<IHerculesTagsBuilder, TValue> valueBuilder)
        {
            foreach (var value in values)
            {
                valueBuilder(this, value);
            }

            return this;
        }

        public IHerculesTagsBuilder AddNull(string key) => this;

        public IHerculesTagsBuilder RemoveTags(string key) => this;
    }
}