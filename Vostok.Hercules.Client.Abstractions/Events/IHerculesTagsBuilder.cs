using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Events
{
    [PublicAPI]
    public partial interface IHerculesTagsBuilder
    {
        /// <summary>
        /// <para>Adds a scalar tag with given <paramref name="key"/> and <paramref name="value"/> to the tags collection.</para>
        /// <para>Conflict resolution (behaviour when a tag with such name already exists) is implementation-specific.</para>
        /// <para>Returned value is utilized solely for the purpose of fluent syntax (chaining calls) and should not return a different instance of <see cref="IHerculesTagsBuilder"/>.</para>
        /// </summary>
        IHerculesTagsBuilder AddValue([NotNull] string key, byte value);

        /// <summary>
        /// <para>Adds a primitive array tag with given <paramref name="key"/> and <paramref name="values"/> to the tags collection.</para>
        /// <para>Conflict resolution (behaviour when a tag with such name already exists) is implementation-specific.</para>
        /// <para>Returned value is utilized solely for the purpose of fluent syntax (chaining calls) and should not return a different instance of <see cref="IHerculesTagsBuilder"/>.</para>
        /// </summary>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] IReadOnlyList<byte> values);

        /// <inheritdoc cref="AddVector(string,System.Collections.Generic.IReadOnlyList{byte})"/>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] IEnumerable<byte> values);

        /// <inheritdoc cref="AddVector(string,System.Collections.Generic.IReadOnlyList{byte})"/>
        IHerculesTagsBuilder AddVector([NotNull] string key, [NotNull] byte[] values);

        /// <summary>
        /// <para>Adds a container tag with given <paramref name="key"/> and contents built using given <paramref name="valueBuilder"/> delegate.</para>
        /// <para>Conflict resolution (behaviour when a tag with such name already exists) is implementation-specific.</para>
        /// <para>Returned value is utilized solely for the purpose of fluent syntax (chaining calls) and should not return a different instance of <see cref="IHerculesTagsBuilder"/>.</para>
        /// </summary>
        IHerculesTagsBuilder AddContainer([NotNull] string key, [NotNull] Action<IHerculesTagsBuilder> valueBuilder);

        /// <summary>
        /// <para>Adds a tag that represents an array of containers with given <paramref name="key"/> and container values built with given <paramref name="valueBuilders"/> delegates.</para>
        /// <para>Conflict resolution (behaviour when a tag with such name already exists) is implementation-specific.</para>
        /// <para>Returned value is utilized solely for the purpose of fluent syntax (chaining calls) and should not return a different instance of <see cref="IHerculesTagsBuilder"/>.</para>
        /// </summary>
        IHerculesTagsBuilder AddVectorOfContainers([NotNull] string key, [NotNull] IReadOnlyList<Action<IHerculesTagsBuilder>> valueBuilders);
    }
}