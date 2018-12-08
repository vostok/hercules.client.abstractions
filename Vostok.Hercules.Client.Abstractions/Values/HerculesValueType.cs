using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Values
{
    /// <summary>
    /// <para>Represents all known types of values in Hercules tags.</para>
    /// <para>Note that numeric values of this enum do not correspond to values expected in binary format by Hercules.</para>
    /// </summary>
    [PublicAPI]
    public enum HerculesValueType
    {
        Byte,
        Short,
        Int,
        Long,
        Bool,
        Float,
        Double,
        Guid,
        String,
        Vector,
        Container,
        Null
    }
}