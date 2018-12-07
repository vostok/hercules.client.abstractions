using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Events
{
    [PublicAPI]
    public partial interface IHerculesTagsBuilder
    {
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