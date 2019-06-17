using System;
using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Events
{
    [PublicAPI]
    public class HerculesEventBuilder : HerculesTagsBuilder, IHerculesEventBuilder, IHerculesEventBuilder<HerculesEvent>
    {
        private DateTimeOffset eventTimestamp;

        public HerculesEventBuilder()
        {
        }

        public HerculesEventBuilder(HerculesEvent @event)
            : base(@event.Tags)
        {
            eventTimestamp = @event.Timestamp;
        }

        /// <returns>Resulting <see cref="HerculesEvent"/></returns>
        public HerculesEvent BuildEvent() => new HerculesEvent(eventTimestamp, BuildTags());

        /// <inheritdoc />
        public IHerculesEventBuilder<HerculesEvent> SetTimestamp(DateTimeOffset timestamp)
        {
            eventTimestamp = timestamp;
            return this;
        }

        /// <inheritdoc />
        IHerculesEventBuilder IHerculesEventBuilder.SetTimestamp(DateTimeOffset timestamp)
        {
            eventTimestamp = timestamp;
            return this;
        }
    }
}