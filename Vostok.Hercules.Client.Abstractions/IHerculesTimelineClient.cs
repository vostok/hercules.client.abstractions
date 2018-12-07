using System;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Models;
using Vostok.Hercules.Client.Abstractions.Queries;
using Vostok.Hercules.Client.Abstractions.Results;

namespace Vostok.Hercules.Client.Abstractions
{
    /// <summary>
    /// <para><see cref="IHerculesTimelineClient"/> is your go-to API to read events from timelines.</para>
    /// <para>See <see cref="ReadTimelineQuery"/>, <see cref="ReadTimelineResult"/> and <see cref="TimelineCoordinates"/> to find out more about how it's done.</para>
    /// </summary>
    [PublicAPI]
    public interface IHerculesTimelineClient
    {
        [ItemNotNull]
        Task<ReadTimelineResult> ReadAsync([NotNull] ReadTimelineQuery query, TimeSpan timeout, CancellationToken cancellationToken = default);
    }
}