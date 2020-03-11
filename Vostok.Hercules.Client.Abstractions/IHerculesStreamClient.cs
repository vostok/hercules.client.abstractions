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
    /// <para><see cref="IHerculesStreamClient"/> is your go-to API to read events from streams.</para>
    /// <para>See <see cref="ReadStreamQuery"/>, <see cref="ReadStreamResult"/> and <see cref="StreamCoordinates"/> to find out more about how it's done.</para>
    /// </summary>
    [PublicAPI]
    public interface IHerculesStreamClient
    {
        [ItemNotNull]
        Task<ReadStreamResult> ReadAsync([NotNull] ReadStreamQuery query, TimeSpan timeout, CancellationToken cancellationToken = default);

        [ItemNotNull]
        Task<ReadStreamIEnumerableResult> ReadIEnumerableAsync([NotNull] ReadStreamQuery query, TimeSpan timeout, CancellationToken cancellationToken = default);

        [ItemNotNull]
        Task<SeekToEndStreamResult> SeekToEndAsync([NotNull] SeekToEndStreamQuery query, TimeSpan timeout, CancellationToken cancellationToken = default);
    }
}