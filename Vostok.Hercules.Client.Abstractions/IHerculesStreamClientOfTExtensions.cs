using System;
using System.Threading;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Queries;
using Vostok.Hercules.Client.Abstractions.Results;

namespace Vostok.Hercules.Client.Abstractions
{
    [PublicAPI]
    public static class IHerculesStreamClientOfTExtensions
    {
        [NotNull]
        public static ReadStreamResult<T> Read<T>(
            [NotNull] this IHerculesStreamClient<T> client,
            [NotNull] ReadStreamQuery query,
            TimeSpan timeout,
            CancellationToken cancellationToken = default) =>
            client.ReadAsync(query, timeout, cancellationToken).GetAwaiter().GetResult();

        [NotNull]
        public static ReadStreamIEnumerableResult<T> ReadIEnumerableAsync<T>(
            [NotNull] this IHerculesStreamClient<T> client,
            [NotNull] ReadStreamQuery query,
            TimeSpan timeout,
            CancellationToken cancellationToken = default) =>
            client.ReadIEnumerableAsync(query, timeout, cancellationToken).GetAwaiter().GetResult();

        [NotNull]
        public static SeekToEndStreamResult SeekToEnd<T>(
            [NotNull] this IHerculesStreamClient<T> client,
            [NotNull] SeekToEndStreamQuery query,
            TimeSpan timeout,
            CancellationToken cancellationToken = default) =>
            client.SeekToEndAsync(query, timeout, cancellationToken).GetAwaiter().GetResult();
    }
}