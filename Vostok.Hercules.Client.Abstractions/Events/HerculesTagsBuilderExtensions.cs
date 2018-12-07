using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Events
{
    /// <summary>
    /// A set of extensions for <see cref="IHerculesTagsBuilder"/>.
    /// </summary>
    [PublicAPI]
    public static class HerculesTagsBuilderExtensions
    {
        /// <summary>
        /// <para>Adds a tag that represents an array of containers with given <paramref name="key"/> and container values built from given <paramref name="values"/> via <paramref name="valueBuilder"/> delegate.</para>
        /// <para>Conflict resolution (behaviour when a tag with such name already exists) is implementation-specific.</para>
        /// <para>Returned value is utilized solely for the purpose of fluent syntax (chaining calls) and should not return a different instance of <see cref="IHerculesTagsBuilder"/>.</para>
        /// </summary>
        public static IHerculesTagsBuilder AddVectorOfContainers<TValue>(
            this IHerculesTagsBuilder builder,
            string key,
            IReadOnlyList<TValue> values,
            Action<IHerculesTagsBuilder, TValue> valueBuilder)
            => builder.AddVectorOfContainers(key,
                values.Select(x => new Action<IHerculesTagsBuilder>(b => valueBuilder(b, x))).ToArray());
    }
}