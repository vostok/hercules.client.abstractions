using System;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Queries;
using Vostok.Hercules.Client.Abstractions.Results;

namespace Vostok.Hercules.Client.Abstractions
{
    [PublicAPI]
    public static class IHerculesManagementClientExtensions
    {
        public static HerculesResult CreateStream(
            [NotNull] this IHerculesManagementClient client, [NotNull] CreateStreamQuery query, TimeSpan timeout)
        {
            return client.CreateStreamAsync(query, timeout).GetAwaiter().GetResult();
        }

        public static HerculesResult CreateTimeline(
            [NotNull] this IHerculesManagementClient client, [NotNull] CreateTimelineQuery query, TimeSpan timeout)
        {
            return client.CreateTimelineAsync(query, timeout).GetAwaiter().GetResult();
        }

        public static DeleteStreamResult DeleteStream(
            [NotNull] this IHerculesManagementClient client, [NotNull] string name, TimeSpan timeout)
        {
            return client.DeleteStreamAsync(name, timeout).GetAwaiter().GetResult();
        }

        public static DeleteTimelineResult DeleteTimeline(
            [NotNull] this IHerculesManagementClient client, [NotNull] string name, TimeSpan timeout)
        {
            return client.DeleteTimelineAsync(name, timeout).GetAwaiter().GetResult();
        }

        public static HerculesResult<string[]> ListStreams(
            [NotNull] this IHerculesManagementClient client, TimeSpan timeout)
        {
            return client.ListStreamsAsync(timeout).GetAwaiter().GetResult();
        }
    }
}