using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Events
{
    [PublicAPI]
    public interface IHerculesTagsBuilder
    {
        /// <summary>
        /// <para>Adds a scalar tag with given <paramref name="key"/> and <paramref name="value"/> to the tags collection.</para>
        /// <para>Conflict resolution (behaviour when a tag with such name already exists) is implementation-specific.</para>
        /// <para>Returned value is utilized solely for the purpose of fluent syntax (chaining calls) and should not return a different instance of <see cref="IHerculesTagsBuilder"/>.</para>
        /// </summary>
        IHerculesTagsBuilder AddValue([NotNull] string key, byte value);

        /// <summary><inheritdoc cref="AddValue(string,byte)"/></summary>
        IHerculesTagsBuilder AddValue([NotNull] string key, short value);

        /// <summary><inheritdoc cref="AddValue(string,byte)"/></summary>
        IHerculesTagsBuilder AddValue([NotNull] string key, int value);

        /// <summary><inheritdoc cref="AddValue(string,byte)"/></summary>
        IHerculesTagsBuilder AddValue([NotNull] string key, long value);

        /// <summary><inheritdoc cref="AddValue(string,byte)"/></summary>
        IHerculesTagsBuilder AddValue([NotNull] string key, bool value);

        /// <summary><inheritdoc cref="AddValue(string,byte)"/></summary>
        IHerculesTagsBuilder AddValue([NotNull] string key, float value);

        /// <summary><inheritdoc cref="AddValue(string,byte)"/></summary>
        IHerculesTagsBuilder AddValue([NotNull] string key, double value);

        /// <summary><inheritdoc cref="AddValue(string,byte)"/></summary>
        IHerculesTagsBuilder AddValue([NotNull] string key, Guid value);

        /// <summary><inheritdoc cref="AddValue(string,byte)"/></summary>
        IHerculesTagsBuilder AddValue([NotNull] string key, [NotNull] string value);

        /// <summary>
        /// <para>Adds a primitive array tag with given <paramref name="key"/> and <paramref name="values"/> to the tags collection.</para>
        /// <para>Conflict resolution (behaviour when a tag with such name already exists) is implementation-specific.</para>
        /// <para>Returned value is utilized solely for the purpose of fluent syntax (chaining calls) and should not return a different instance of <see cref="IHerculesTagsBuilder"/>.</para>
        /// </summary>
        IHerculesTagsBuilder AddArray([NotNull] string key, [NotNull] IReadOnlyList<byte> values);

        /// <summary><inheritdoc cref="AddArray(string,IReadOnlyList{byte})"/></summary>
        IHerculesTagsBuilder AddArray([NotNull] string key, [NotNull] IReadOnlyList<short> values);

        /// <summary><inheritdoc cref="AddArray(string,IReadOnlyList{byte})"/></summary>
        IHerculesTagsBuilder AddArray([NotNull] string key, [NotNull] IReadOnlyList<int> values);

        /// <summary><inheritdoc cref="AddArray(string,IReadOnlyList{byte})"/></summary>
        IHerculesTagsBuilder AddArray([NotNull] string key, [NotNull] IReadOnlyList<long> values);

        /// <summary><inheritdoc cref="AddArray(string,IReadOnlyList{byte})"/></summary>
        IHerculesTagsBuilder AddArray([NotNull] string key, [NotNull] IReadOnlyList<bool> values);

        /// <summary><inheritdoc cref="AddArray(string,IReadOnlyList{byte})"/></summary>
        IHerculesTagsBuilder AddArray([NotNull] string key, [NotNull] IReadOnlyList<float> values);

        /// <summary><inheritdoc cref="AddArray(string,IReadOnlyList{byte})"/></summary>
        IHerculesTagsBuilder AddArray([NotNull] string key, [NotNull] IReadOnlyList<double> values);

        /// <summary><inheritdoc cref="AddArray(string,IReadOnlyList{byte})"/></summary>
        IHerculesTagsBuilder AddArray([NotNull] string key, [NotNull] IReadOnlyList<Guid> values);

        /// <summary><inheritdoc cref="AddArray(string,IReadOnlyList{byte})"/></summary>
        IHerculesTagsBuilder AddArray([NotNull] string key, [NotNull] IReadOnlyList<string> values);

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
        IHerculesTagsBuilder AddArrayOfContainers([NotNull] string key, [NotNull] IReadOnlyList<Action<IHerculesTagsBuilder>> valueBuilders);
    }
}