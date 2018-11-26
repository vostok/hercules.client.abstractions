namespace Vostok.Hercules.Client.Abstractions.Values
{
    internal class HerculesBool : HerculesValue<bool>
    {
        public HerculesBool(bool value)
            : base(value)
        {
        }

        public override HerculesValueType Type => HerculesValueType.Bool;
    }
}