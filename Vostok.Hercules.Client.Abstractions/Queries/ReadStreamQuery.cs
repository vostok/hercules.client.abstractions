using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Queries
{
    [PublicAPI]
    public class ReadStreamQuery
    {
        public string StreamName { get; set; }
    }
}
