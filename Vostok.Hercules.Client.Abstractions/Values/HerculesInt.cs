namespace Vostok.Hercules.Client.Abstractions.Values
{
    internal class HerculesInt : HerculesValue<int>
    {
        public HerculesInt(int value)
            : base(value)
        {
        }

        public override HerculesValueType Type => HerculesValueType.Int;
    }
}