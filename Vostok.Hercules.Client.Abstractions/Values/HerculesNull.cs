using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Values
{
    [PublicAPI]
    public class HerculesNull
    {
        public static readonly HerculesNull Instance = new HerculesNull();
    }
}