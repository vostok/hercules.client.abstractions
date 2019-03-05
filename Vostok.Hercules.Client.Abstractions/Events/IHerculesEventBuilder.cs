using System;
using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Events
{
    [PublicAPI]
    public interface IHerculesEventBuilder : IHerculesTagsBuilder
    {
        /// <summary>
        /// <para>Sets a <paramref name="timestamp"/> that will be used in resulting <see cref="HerculesEvent"/>.</para>
        /// <para><paramref name="timestamp"/> should be greater than 1st Jan 1970 in UTC (unix epoch start).</para>
        /// </summary>
        [NotNull]
        IHerculesEventBuilder SetTimestamp(DateTimeOffset timestamp);
    }
}