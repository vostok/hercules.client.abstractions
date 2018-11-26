using System.Collections.Generic;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Events;

namespace Vostok.Hercules.Client.Abstractions.Queries
{
    [PublicAPI]
    public class InsertQuery
    {
        public string StreamName { get; set; }

        public IList<HerculesEvent> Events { get; set; }
    }
}