using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Values
{
    [PublicAPI]
    public abstract partial class HerculesValue
    {
        public abstract HerculesValueType Type { get; }

        public abstract object Value { get; }
    }
}
