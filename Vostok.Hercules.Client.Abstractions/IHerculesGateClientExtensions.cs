using System;
using System.Threading;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Queries;
using Vostok.Hercules.Client.Abstractions.Results;

namespace Vostok.Hercules.Client.Abstractions
{
    [PublicAPI]
    public static class IHerculesGateClientExtensions
    {
        [NotNull]
        public static InsertEventsResult Insert(
            [NotNull] this IHerculesGateClient client,
            [NotNull] InsertEventsQuery query,
            TimeSpan timeout,
            CancellationToken cancellationToken = default) =>
            client.InsertAsync(query, timeout, cancellationToken).GetAwaiter().GetResult();
    }
}