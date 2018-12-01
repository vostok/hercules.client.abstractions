using System;
using System.Threading;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Queries;
using Vostok.Hercules.Client.Abstractions.Results;

namespace Vostok.Hercules.Client.Abstractions
{
    [PublicAPI]
    public static class IHerculesTimelineClientExtensions
    {
        [NotNull]
        public static ReadTimelineResult Read(
            [NotNull] IHerculesTimelineClient client, [NotNull] ReadTimelineQuery query, TimeSpan timeout, CancellationToken cancellationToken = default)
        {
            return client.ReadAsync(query, timeout, cancellationToken).GetAwaiter().GetResult();
        }
    }
}