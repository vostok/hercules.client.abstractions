using System;
using System.Threading;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Queries;
using Vostok.Hercules.Client.Abstractions.Results;

namespace Vostok.Hercules.Client.Abstractions
{
    [PublicAPI]
    public static class IHerculesStreamClientExtensions
    {
        [NotNull]
        public static ReadStreamResult Read(
            [NotNull] IHerculesStreamClient client, [NotNull] ReadStreamQuery query, TimeSpan timeout, CancellationToken cancellationToken = default)
        {
            return client.ReadAsync(query, timeout, cancellationToken).GetAwaiter().GetResult();
        }
    }
}