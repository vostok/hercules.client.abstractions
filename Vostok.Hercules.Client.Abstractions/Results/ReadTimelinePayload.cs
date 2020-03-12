using System.Collections.Generic;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Events;
using Vostok.Hercules.Client.Abstractions.Models;

namespace Vostok.Hercules.Client.Abstractions.Results
{
    [PublicAPI]
    public class ReadTimelinePayload : ReadTimelinePayload<HerculesEvent>
    {
        public ReadTimelinePayload([NotNull] IList<HerculesEvent> events, [NotNull] TimelineCoordinates next)
            : base(events, next)
        {
        }
    }
}