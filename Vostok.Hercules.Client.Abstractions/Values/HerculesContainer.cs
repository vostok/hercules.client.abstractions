using Vostok.Hercules.Client.Abstractions.Events;

namespace Vostok.Hercules.Client.Abstractions.Values
{
    internal class HerculesContainer : HerculesValue<HerculesTags>
    {
        public HerculesContainer(HerculesTags value)
            : base(value)
        {
        }

        public override HerculesValueType Type => HerculesValueType.Container;
    }
}