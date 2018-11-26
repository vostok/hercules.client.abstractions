namespace Vostok.Hercules.Client.Abstractions.Values
{
    internal class HerculesFloat : HerculesValue<float>
    {
        public HerculesFloat(float value)
            : base(value)
        {
        }

        public override HerculesValueType Type => HerculesValueType.Float;
    }
}