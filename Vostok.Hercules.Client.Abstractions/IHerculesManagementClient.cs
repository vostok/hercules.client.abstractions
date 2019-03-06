using System;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Models;
using Vostok.Hercules.Client.Abstractions.Queries;
using Vostok.Hercules.Client.Abstractions.Results;

namespace Vostok.Hercules.Client.Abstractions
{
    /// <summary>
    /// <para><see cref="IHerculesManagementClient"/> provides CRUD for streams and timelines and lets you manage permissions and API keys.</para>
    /// <para>Note that many of the operations performed by this client require a special admin API key.</para>
    /// </summary>
    [PublicAPI]
    public interface IHerculesManagementClient
    {
        [ItemNotNull]
        Task<HerculesResult> CreateStreamAsync([NotNull] CreateStreamQuery query, TimeSpan timeout);

        [ItemNotNull]
        Task<HerculesResult> CreateTimelineAsync([NotNull] CreateTimelineQuery query, TimeSpan timeout);

        [ItemNotNull]
        Task<DeleteStreamResult> DeleteStreamAsync([NotNull] string name, TimeSpan timeout);

        [ItemNotNull]
        Task<DeleteTimelineResult> DeleteTimelineAsync([NotNull] string name, TimeSpan timeout);

        [ItemNotNull]
        Task<HerculesResult<StreamDescription>> GetStreamDescriptionAsync([NotNull] string name, TimeSpan timeout);

        [ItemNotNull]
        Task<HerculesResult<TimelineDescription>> GetTimelineDescriptionAsync ([NotNull] string name, TimeSpan timeout);

        [ItemNotNull]
        Task<HerculesResult<string[]>> ListStreamsAsync(TimeSpan timeout);

        [ItemNotNull]
        Task<HerculesResult<string[]>> ListTimelinesAsync(TimeSpan timeout);
    }
}