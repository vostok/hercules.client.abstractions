using System.Threading.Tasks;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Queries;
using Vostok.Hercules.Client.Abstractions.Results;

namespace Vostok.Hercules.Client.Abstractions
{
    [PublicAPI]
    public interface IHerculesManagementClient
    {
        Task<HerculesStatus> CreateStreamAsync([NotNull] CreateStreamQuery query);

        Task<HerculesStatus> CreateTimelineAsync([NotNull] CreateTimelineQuery query);
    }
}