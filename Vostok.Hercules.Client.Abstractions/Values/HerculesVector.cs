namespace Vostok.Hercules.Client.Abstractions.Values
{
    internal class HerculesVector : HerculesValue<HerculesValue[]>
    {
        public HerculesVector(HerculesValue[] value)
            : base(value)
        {
        }

        public override HerculesValueType Type => HerculesValueType.Vector;
    }
}