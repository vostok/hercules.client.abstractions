namespace Vostok.Hercules.Client.Abstractions.Values
{
    internal class HerculesLong : HerculesValue<long>
    {
        public HerculesLong(long value)
            : base(value)
        {
        }

        public override HerculesValueType Type => HerculesValueType.Long;
    }
}