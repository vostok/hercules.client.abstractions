using System;
using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Events
{
    [PublicAPI]
    public class HerculesEventBuilderUnsafe : HerculesTagsBuilderUnsafe, IHerculesEventBuilder
    {
        private DateTimeOffset eventTimestamp;

        public HerculesEventBuilderUnsafe()
        {
        }

        public HerculesEventBuilderUnsafe(HerculesEvent @event)
            : base(@event.Tags)
        {
            eventTimestamp = @event.Timestamp;
        }

        /// <returns>Resulting <see cref="HerculesEvent"/></returns>
        public HerculesEvent BuildEvent() => new HerculesEvent(eventTimestamp, BuildTags());

        public IHerculesEventBuilder SetTimestamp(DateTimeOffset timestamp)
        {
            eventTimestamp = timestamp;
            return this;
        }
    }
}