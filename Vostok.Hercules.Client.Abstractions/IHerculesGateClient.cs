using System;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Queries;
using Vostok.Hercules.Client.Abstractions.Results;

namespace Vostok.Hercules.Client.Abstractions
{
    [PublicAPI]
    public interface IHerculesGateClient
    {
        [ItemNotNull]
        Task<HerculesInsertResult> InsertAsync([NotNull] InsertQuery query, TimeSpan timeout, CancellationToken cancellationToken = default);
    }
}
