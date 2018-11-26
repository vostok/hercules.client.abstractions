namespace Vostok.Hercules.Client.Abstractions.Values
{
    internal class HerculesByte : HerculesValue<byte>
    {
        public HerculesByte(byte value)
            : base(value)
        {
        }

        public override HerculesValueType Type => HerculesValueType.Byte;
    }
}