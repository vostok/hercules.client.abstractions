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
        public static SeekToEndStreamResult SeekToEnd(
            [NotNull] this IHerculesStreamClient client,
            [NotNull] SeekToEndStreamQuery query,
            TimeSpan timeout,
            CancellationToken cancellationToken = default) =>
            client.SeekToEndAsync(query, timeout, cancellationToken).GetAwaiter().GetResult();
    }
}