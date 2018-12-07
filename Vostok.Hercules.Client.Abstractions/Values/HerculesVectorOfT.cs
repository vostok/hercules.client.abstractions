namespace Vostok.Hercules.Client.Abstractions.Values
{
    internal class HerculesVector<TValue> : HerculesVector
    {
        private static readonly HerculesValueType? type = HerculesValueHelpers.TryMapToHerculesType(typeof(TValue));
        
        public HerculesVector(TValue[] value)
        {
            if (type == null)
                HerculesValueHelpers.ThrowNotSupportedException(typeof(TValue));
            
            TypedValue = value;
        }

        public TValue[] TypedValue { get; }

        public override HerculesValueType ElementType => type.Value;

        protected override HerculesValue[] CreateArrayOfValues()
        {
            var array = new HerculesValue[TypedValue.Length];
            
            for (var i = 0; i < array.Length; i++)
                array[i] = new HerculesValue<TValue>(TypedValue[i]);

            return array;
        }
    }
}