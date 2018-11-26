using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Values
{
    [PublicAPI]
    public enum HerculesValueType
    {
        Int,
        Long,
        Guid,
        String,
        Array,
        Container
        // ...
    }
}