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
    public interface IHerculesStreamClient<T>
    {
        [ItemNotNull]
        Task<ReadStreamResult<T>> ReadAsync([NotNull] ReadStreamQuery query, TimeSpan timeout, CancellationToken cancellationToken = default);

        [ItemNotNull]
        Task<ReadStreamIEnumerableResult<T>> ReadIEnumerableAsync([NotNull] ReadStreamQuery query, TimeSpan timeout, CancellationToken cancellationToken = default);

        [ItemNotNull]
        Task<SeekToEndStreamResult> SeekToEndAsync([NotNull] SeekToEndStreamQuery query, TimeSpan timeout, CancellationToken cancellationToken = default);
    }
}