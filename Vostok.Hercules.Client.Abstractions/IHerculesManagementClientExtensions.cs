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
        [NotNull]
        public static HerculesResult CreateStream(
            [NotNull] this IHerculesManagementClient client,
            [NotNull] CreateStreamQuery query,
            TimeSpan timeout) =>
            client.CreateStreamAsync(query, timeout).GetAwaiter().GetResult();

        [NotNull]
        public static HerculesResult CreateTimeline(
            [NotNull] this IHerculesManagementClient client,
            [NotNull] CreateTimelineQuery query,
            TimeSpan timeout) =>
            client.CreateTimelineAsync(query, timeout).GetAwaiter().GetResult();

        [NotNull]
        public static DeleteStreamResult DeleteStream(
            [NotNull] this IHerculesManagementClient client,
            [NotNull] string name,
            TimeSpan timeout) =>
            client.DeleteStreamAsync(name, timeout).GetAwaiter().GetResult();

        [NotNull]
        public static DeleteTimelineResult DeleteTimeline(
            [NotNull] this IHerculesManagementClient client,
            [NotNull] string name,
            TimeSpan timeout) =>
            client.DeleteTimelineAsync(name, timeout).GetAwaiter().GetResult();

        [NotNull]
        public static HerculesResult<StreamDescription> GetStreamDescription(
            [NotNull] this IHerculesManagementClient client,
            [NotNull] string name,
            TimeSpan timeout) =>
            client.GetStreamDescriptionAsync(name, timeout).GetAwaiter().GetResult();

        [NotNull]
        public static HerculesResult<TimelineDescription> GetTimelineDescription(
            [NotNull] this IHerculesManagementClient client,
            [NotNull] string name,
            TimeSpan timeout) =>
            client.GetTimelineDescriptionAsync(name, timeout).GetAwaiter().GetResult();

        [NotNull]
        public static HerculesResult<string[]> ListStreams(
            [NotNull] this IHerculesManagementClient client,
            TimeSpan timeout) =>
            client.ListStreamsAsync(timeout).GetAwaiter().GetResult();

        [NotNull]
        public static HerculesResult<string[]> ListTimelines(
            [NotNull] this IHerculesManagementClient client,
            TimeSpan timeout) =>
            client.ListTimelinesAsync(timeout).GetAwaiter().GetResult();

        public static bool StreamExists(
            [NotNull] this IHerculesManagementClient client,
            [NotNull] string name,
            TimeSpan timeout) =>
            GetStreamDescription(client, name, timeout).IsSuccessful;

        public static bool TimelineExists(
            [NotNull] this IHerculesManagementClient client,
            [NotNull] string name,
            TimeSpan timeout) =>
            GetTimelineDescription(client, name, timeout).IsSuccessful;
    }
}