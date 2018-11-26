namespace Vostok.Hercules.Client.Abstractions.Values
{
    internal class HerculesDouble : HerculesValue<double>
    {
        public HerculesDouble(double value)
            : base(value)
        {
        }

        public override HerculesValueType Type => HerculesValueType.Double;
    }
}