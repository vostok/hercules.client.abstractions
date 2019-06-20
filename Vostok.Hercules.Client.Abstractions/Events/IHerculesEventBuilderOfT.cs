using System;
using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Events
{
    [PublicAPI]
    public interface IHerculesEventBuilder<out T> : IHerculesTagsBuilder
    {
        /// <summary>
        /// <para>Sets a <paramref name="timestamp"/> that will be used in resulting <see cref="HerculesEvent"/>.</para>
        /// <para><paramref name="timestamp"/> should be greater than 1st Jan 1970 in UTC (UNIX epoch start) because Hercules protocol use UNIX epoch-based timestamps.</para>
        /// </summary>
        [NotNull]
        IHerculesEventBuilder<T> SetTimestamp(DateTimeOffset timestamp);

        /// <summary>
        /// Builds event, using current builder state.
        /// </summary>
        [NotNull]
        T BuildEvent();
    }
}