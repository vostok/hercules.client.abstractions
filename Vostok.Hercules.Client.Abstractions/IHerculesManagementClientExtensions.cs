using System;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Models;
using Vostok.Hercules.Client.Abstractions.Queries;
using Vostok.Hercules.Client.Abstractions.Results;

namespace Vostok.Hercules.Client.Abstractions
{
    [PublicAPI]
    public static class HerculesManagementClientExtensions
    {
        public static HerculesResult CreateStream(
            [NotNull] this IHerculesManagementClient client,
            [NotNull] CreateStreamQuery query,
            TimeSpan timeout) =>
            client.CreateStreamAsync(query, timeout).GetAwaiter().GetResult();

        public static HerculesResult CreateTimeline(
            [NotNull] this IHerculesManagementClient client,
            [NotNull] CreateTimelineQuery query,
            TimeSpan timeout) =>
            client.CreateTimelineAsync(query, timeout).GetAwaiter().GetResult();

        public static DeleteStreamResult DeleteStream(
            [NotNull] this IHerculesManagementClient client,
            [NotNull] string name,
            TimeSpan timeout) =>
            client.DeleteStreamAsync(name, timeout).GetAwaiter().GetResult();

        public static DeleteTimelineResult DeleteTimeline(
            [NotNull] this IHerculesManagementClient client,
            [NotNull] string name,
            TimeSpan timeout) =>
            client.DeleteTimelineAsync(name, timeout).GetAwaiter().GetResult();

        public static HerculesResult<StreamDescription> GetStreamDescriptionAsync(
            [NotNull] this IHerculesManagementClient client,
            [NotNull] string name,
            TimeSpan timeout) =>
            client.GetStreamDescriptionAsync(name, timeout).GetAwaiter().GetResult();

        public static HerculesResult<TimelineDescription> GetTimelineDescriptionAsync(
            [NotNull] this IHerculesManagementClient client,
            [NotNull] string name,
            TimeSpan timeout) =>
            client.GetTimelineDescriptionAsync(name, timeout).GetAwaiter().GetResult();

        public static HerculesResult<string[]> ListStreams(
            [NotNull] this IHerculesManagementClient client,
            TimeSpan timeout) =>
            client.ListStreamsAsync(timeout).GetAwaiter().GetResult();

        public static HerculesResult<string[]> ListTimelinesAsync(
            [NotNull] this IHerculesManagementClient client,
            TimeSpan timeout) =>
            client.ListTimelinesAsync(timeout).GetAwaiter().GetResult();
    }
}