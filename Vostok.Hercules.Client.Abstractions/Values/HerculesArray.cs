namespace Vostok.Hercules.Client.Abstractions.Values
{
    internal class HerculesArray : HerculesValue<HerculesValue[]>
    {
        public HerculesArray(HerculesValue[] value)
            : base(value)
        {
        }

        public override HerculesValueType Type => HerculesValueType.Array;
    }
}