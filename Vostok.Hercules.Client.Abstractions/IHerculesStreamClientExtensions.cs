using System;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Events;
using Vostok.Hercules.Client.Abstractions.Queries;
using Vostok.Hercules.Client.Abstractions.Results;

namespace Vostok.Hercules.Client.Abstractions
{
    [PublicAPI]
    public static class IHerculesStreamClientExtensions
    {
        [NotNull]
        public static ReadStreamResult Read(
            [NotNull] this IHerculesStreamClient client,
            [NotNull] ReadStreamQuery query,
            TimeSpan timeout,
            CancellationToken cancellationToken = default) =>
            client.ReadAsync(query, timeout, cancellationToken).GetAwaiter().GetResult();

        [NotNull]
        public static ReadStreamIEnumerableResult ReadIEnumerable(
            [NotNull] this IHerculesStreamClient client,
            [NotNull] ReadStreamQuery query,
            TimeSpan timeout,
            CancellationToken cancellationToken = default) =>
            client.ReadIEnumerableAsync(query, timeout, cancellationToken).GetAwaiter().GetResult();

        [NotNull]
        public static SeekToEndStreamResult SeekToEnd(
            [NotNull] this IHerculesStreamClient client,
            [NotNull] SeekToEndStreamQuery query,
            TimeSpan timeout,
            CancellationToken cancellationToken = default) =>
            client.SeekToEndAsync(query, timeout, cancellationToken).GetAwaiter().GetResult();

        [NotNull]
        public static IHerculesStreamClient<HerculesEvent> ToGenericClient([NotNull] this IHerculesStreamClient client) =>
            new GenericAdapter(client);

        private class GenericAdapter : IHerculesStreamClient<HerculesEvent>
        {
            private readonly IHerculesStreamClient client;

            public GenericAdapter(IHerculesStreamClient client)
            {
                this.client = client;
            }

            public async Task<ReadStreamResult<HerculesEvent>> ReadAsync(ReadStreamQuery query, TimeSpan timeout, CancellationToken cancellationToken = default) =>
                await client.ReadAsync(query, timeout, cancellationToken).ConfigureAwait(false);

            public async Task<ReadStreamIEnumerableResult<HerculesEvent>> ReadIEnumerableAsync(ReadStreamQuery query, TimeSpan timeout, CancellationToken cancellationToken = default) =>
                await client.ReadIEnumerableAsync(query, timeout, cancellationToken).ConfigureAwait(false);

            public Task<SeekToEndStreamResult> SeekToEndAsync(SeekToEndStreamQuery query, TimeSpan timeout, CancellationToken cancellationToken = default) =>
                client.SeekToEndAsync(query, timeout, cancellationToken);
        }
    }
}