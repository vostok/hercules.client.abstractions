using System.Collections.Generic;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Values;

namespace Vostok.Hercules.Client.Abstractions.Events
{
    [PublicAPI]
    public class HerculesTags
    {
        // TODO(iloktionov): convenient indexer

        // TODO(iloktionov): rename or hide property
        public IReadOnlyDictionary<string, HerculesValue> Tags { get; }
    }
}