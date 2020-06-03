using System;
using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Events
{
    [PublicAPI]
    public class HerculesEventBuilderOfT : HerculesEventBuilder, IHerculesEventBuilder<HerculesEvent>
    {
        public new IHerculesEventBuilder<HerculesEvent> SetTimestamp(DateTimeOffset timestamp)
        {
            base.SetTimestamp(timestamp);
            return this;
        }
    }
}