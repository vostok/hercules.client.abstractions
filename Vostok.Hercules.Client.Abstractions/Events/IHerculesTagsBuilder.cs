using System;
using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Events
{
    [PublicAPI]
    public interface IHerculesTagsBuilder
    {
        IHerculesTagsBuilder AddContainer([NotNull] string name, Action<IHerculesTagsBuilder> valueBuilder);

        IHerculesTagsBuilder AddValue([NotNull] string name, int value);

        IHerculesTagsBuilder AddValue([NotNull] string name, long value);

        // ...

        IHerculesTagsBuilder AddArray([NotNull] string name, int[] values);

        IHerculesTagsBuilder AddArray([NotNull] string name, long[] values);

        // ...

        IHerculesTagsBuilder AddArrayOfContainers([NotNull] string name, Action<IHerculesTagsBuilder>[] valueBuilders);
    }
}