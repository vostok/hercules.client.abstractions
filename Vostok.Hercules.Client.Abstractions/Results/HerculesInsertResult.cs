using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Results
{
    [PublicAPI]
    public class HerculesInsertResult : HerculesResult
    {
        public HerculesInsertResult(HerculesStatus status)
            : base(status)
        {
        }
    }
}