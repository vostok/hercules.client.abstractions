using System;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Queries;
using Vostok.Hercules.Client.Abstractions.Results;

namespace Vostok.Hercules.Client.Abstractions
{
    [PublicAPI]
    public interface IHerculesStreamClient
    {
        [ItemNotNull]
        Task<ReadStreamResult> ReadAsync([NotNull] ReadStreamQuery query, TimeSpan timeout, CancellationToken cancellationToken = default);
    }
}