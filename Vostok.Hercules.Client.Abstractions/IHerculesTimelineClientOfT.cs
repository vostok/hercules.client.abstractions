using System;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Queries;
using Vostok.Hercules.Client.Abstractions.Results;

namespace Vostok.Hercules.Client.Abstractions
{
    /// <summary>
    /// <inheritdoc cref="IHerculesStreamClient"/>
    /// </summary>
    [PublicAPI]
    public interface IHerculesTimelineClient<T>
    {
        [ItemNotNull]
        Task<ReadTimelineResult<T>> ReadAsync([NotNull] ReadTimelineQuery query, TimeSpan timeout, CancellationToken cancellationToken = default);
    }
}