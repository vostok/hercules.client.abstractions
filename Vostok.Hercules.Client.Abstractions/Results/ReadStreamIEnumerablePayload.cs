using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Events;
using Vostok.Hercules.Client.Abstractions.Models;

namespace Vostok.Hercules.Client.Abstractions.Results
{
    [PublicAPI]
    public class ReadStreamIEnumerablePayload : ReadStreamIEnumerablePayload<HerculesEvent>
    {
        public ReadStreamIEnumerablePayload([NotNull] IEnumerable<HerculesEvent> events, [NotNull] StreamCoordinates current, [NotNull] StreamCoordinates next, [CanBeNull] Action dispose)
            : base(events, current, next, dispose)
        {
        }
    }
}