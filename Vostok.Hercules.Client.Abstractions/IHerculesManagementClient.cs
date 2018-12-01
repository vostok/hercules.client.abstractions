using System.Threading.Tasks;
using JetBrains.Annotations;
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
        Task<HerculesStatus> CreateStreamAsync([NotNull] CreateStreamQuery query);

        Task<HerculesStatus> CreateTimelineAsync([NotNull] CreateTimelineQuery query);
    }
}