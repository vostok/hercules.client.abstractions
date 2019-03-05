using System;
using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Events
{
    [PublicAPI]
    public class HerculesEventBuilder : HerculesTagsBuilder, IHerculesEventBuilder
    {
        private DateTimeOffset eventTimestamp;

        /// <returns>Resulting <see cref="HerculesEvent"/></returns>
        public HerculesEvent BuildEvent() => new HerculesEvent(eventTimestamp, BuildTags());

        /// <inheritdoc />
        public IHerculesEventBuilder SetTimestamp(DateTimeOffset timestamp)
        {
            eventTimestamp = timestamp;

            return this;
        }
    }
}