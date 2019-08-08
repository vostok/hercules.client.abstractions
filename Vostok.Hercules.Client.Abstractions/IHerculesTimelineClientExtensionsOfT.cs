using System;
using System.Collections.Generic;
using System.Threading;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Models;
using Vostok.Hercules.Client.Abstractions.Queries;
using Vostok.Hercules.Client.Abstractions.Results;

namespace Vostok.Hercules.Client.Abstractions
{
    [PublicAPI]
    public static class HerculesTimelineClientOfTExtensions
    {
        [NotNull]
        public static ReadTimelineResult<T> Read<T>(
            [NotNull] this IHerculesTimelineClient<T> client,
            [NotNull] ReadTimelineQuery query,
            TimeSpan timeout,
            CancellationToken cancellationToken = default) =>
            client.ReadAsync(query, timeout, cancellationToken).GetAwaiter().GetResult();

        [NotNull]
        public static IEnumerable<T> Scan<T>(
            [NotNull] this IHerculesTimelineClient<T> client,
            [NotNull] ScanTimelineQuery query,
            TimeSpan perRequestTimeout,
            CancellationToken cancellationToken = default)
        {
            var nextCoordinates = TimelineCoordinates.Empty;

            while (true)
            {
                var readQuery = new ReadTimelineQuery(query.Name)
                {
                    From = query.From,
                    To = query.To,
                    Limit = query.BatchSize,
                    ClientShard = query.ClientShard,
                    ClientShardCount = query.ClientShardCount,
                    Coordinates = nextCoordinates
                };

                var readPayload = client.Read(readQuery, perRequestTimeout, cancellationToken).Payload;

                foreach (var @event in readPayload.Events)
                {
                    yield return @event;
                }

                if (readPayload.Events.Count < query.BatchSize)
                    break;

                nextCoordinates = readPayload.Next;
            }
        }
    }
}