namespace Vostok.Hercules.Client.Abstractions.Values
{
    internal class HerculesString : HerculesValue<string>
    {
        public HerculesString(string value)
            : base(value)
        {
        }

        public override HerculesValueType Type => HerculesValueType.String;
    }
}