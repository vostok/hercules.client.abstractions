namespace Vostok.Hercules.Client.Abstractions.Values
{
    internal class HerculesValue<TValue> : HerculesValue
    {
        private static readonly HerculesValueType? type = TryMapToHerculesType(typeof(TValue));
        
        public HerculesValue(TValue value)
        {
            if (type == null)
                ThrowNotSupportedException(typeof(TValue));
            
            TypedValue = value;
        }

        public TValue TypedValue { get; }

        public override HerculesValueType Type => type.Value;
        
        public override object Value => TypedValue;
    }

}