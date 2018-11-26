using System.Collections.Generic;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Events;

namespace Vostok.Hercules.Client.Abstractions.Results
{
    // TODO(iloktionov): add read state to result

    [PublicAPI]
    public class HerculesTimelineReadResult : HerculesResult<IList<HerculesEvent>>
    {
        public HerculesTimelineReadResult(HerculesStatus status, IList<HerculesEvent> payload)
            : base(status, payload)
        {
        }
    }
}