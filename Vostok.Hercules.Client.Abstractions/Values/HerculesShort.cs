namespace Vostok.Hercules.Client.Abstractions.Values
{
    internal class HerculesShort : HerculesValue<short>
    {
        public HerculesShort(short value)
            : base(value)
        {
        }

        public override HerculesValueType Type => HerculesValueType.Short;
    }
}