using System.Collections.Generic;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Events;
using Vostok.Hercules.Client.Abstractions.Models;

namespace Vostok.Hercules.Client.Abstractions.Results
{
    [PublicAPI]
    public class ReadStreamPayload : ReadStreamPayload<HerculesEvent>
    {
        public ReadStreamPayload([NotNull] IList<HerculesEvent> events, [NotNull] StreamCoordinates next)
            : base(events, next)
        {
        }
    }
}