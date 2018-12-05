namespace Vostok.Hercules.Client.Abstractions.Values
{
    internal class HerculesVectorHolder : HerculesValue<HerculesVector>
    {
        public HerculesVectorHolder(HerculesVector value)
            : base(value)
        {
        }

        public override HerculesValueType Type => HerculesValueType.Vector;
    }
}