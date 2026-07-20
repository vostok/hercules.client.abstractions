using System;
using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Events
{
    [PublicAPI]
    public class HerculesEventBuilderOfTUnsafe : HerculesEventBuilderUnsafe, IHerculesEventBuilder<HerculesEvent>
    {
        public HerculesEventBuilderOfTUnsafe()
        {
            
        }
        
        public HerculesEventBuilderOfTUnsafe(int initialCapacity) : base(initialCapacity)
        {
            
        }
        public new IHerculesEventBuilder<HerculesEvent> SetTimestamp(DateTimeOffset timestamp)
        {
            base.SetTimestamp(timestamp);
            return this;
        }
    }
}