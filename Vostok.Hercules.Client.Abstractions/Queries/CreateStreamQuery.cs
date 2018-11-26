using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Common;

namespace Vostok.Hercules.Client.Abstractions.Queries
{
    [PublicAPI]
    public class CreateStreamQuery
    {
        public StreamDescription Description { get; set; }
    }
}