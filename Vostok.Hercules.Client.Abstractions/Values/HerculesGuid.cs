using System;

namespace Vostok.Hercules.Client.Abstractions.Values
{
    internal class HerculesGuid : HerculesValue<Guid>
    {
        public HerculesGuid(Guid value)
            : base(value)
        {
        }

        public override HerculesValueType Type => HerculesValueType.Guid;
    }
}