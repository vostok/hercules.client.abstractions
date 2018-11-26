namespace Vostok.Hercules.Client.Abstractions.Values
{
    internal abstract class HerculesValue<TValue> : HerculesValue
    {
        protected HerculesValue(TValue value)
        {
            TypedValue = value;
        }

        public TValue TypedValue { get; }

        public override object Value => TypedValue;
    }
}