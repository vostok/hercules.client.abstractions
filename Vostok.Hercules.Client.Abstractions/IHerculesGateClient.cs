using System;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Queries;
using Vostok.Hercules.Client.Abstractions.Results;

namespace Vostok.Hercules.Client.Abstractions
{
    /// <summary>
    /// <para><see cref="IHerculesGateClient"/> is a classic "request-response" style API to write events to streams (as opposed to fire-and-forget <see cref="IHerculesSink"/>).</para>
    /// <para>It's intended for batch jobs: data export, periodical synchronization and so on.</para>
    /// <para>It also provides feedback on results of insert operations so that user can retry if needed.</para>
    /// </summary>
    [PublicAPI]
    public interface IHerculesGateClient
    {
        [ItemNotNull]
        Task<InsertEventsResult> InsertAsync([NotNull] InsertEventsQuery query, TimeSpan timeout, CancellationToken cancellationToken = default);
    }
}