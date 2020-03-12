using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Events;
using Vostok.Hercules.Client.Abstractions.Queries;
using Vostok.Hercules.Client.Abstractions.Results;

namespace Vostok.Hercules.Client.Abstractions
{
    [PublicAPI]
    public static class IHerculesTimelineClientExtensions
    {
        [NotNull]
        public static ReadTimelineResult Read(
            [NotNull] this IHerculesTimelineClient client,
            [NotNull] ReadTimelineQuery query,
            TimeSpan timeout,
            CancellationToken cancellationToken = default) =>
            client.ReadAsync(query, timeout, cancellationToken).GetAwaiter().GetResult();

        [NotNull]
        public static IEnumerable<HerculesEvent> Scan(
            [NotNull] this IHerculesTimelineClient client,
            [NotNull] ScanTimelineQuery query,
            TimeSpan perRequestTimeout,
            CancellationToken cancellationToken = default) =>
            client.ToGenericClient().Scan(query, perRequestTimeout, cancellationToken);

        [NotNull]
        public static IHerculesTimelineClient<HerculesEvent> ToGenericClient([NotNull] this IHerculesTimelineClient client) =>
            new GenericAdapter(client);

        private class GenericAdapter : IHerculesTimelineClient<HerculesEvent>
        {
            private readonly IHerculesTimelineClient client;

            public GenericAdapter(IHerculesTimelineClient client) =>
                this.client = client;

            public async Task<ReadTimelineResult<HerculesEvent>> ReadAsync(ReadTimelineQuery query, TimeSpan timeout, CancellationToken cancellationToken = default) =>
                await client.ReadAsync(query, timeout, cancellationToken).ConfigureAwait(false);
        }
    }
}