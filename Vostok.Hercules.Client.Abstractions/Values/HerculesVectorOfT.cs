namespace Vostok.Hercules.Client.Abstractions.Values
{
    internal class HerculesVector<TValue> : HerculesVector
    {
        private static readonly HerculesValueType? type = HerculesValueHelpers.TryMapToHerculesType(typeof(TValue));
        
        public HerculesVector(TValue[] value)
        {
            if (type == null)
                HerculesValueHelpers.ThrowNotSupportedException(typeof(TValue));
            
            Elements = value;
        }

        public TValue[] Elements { get; }

        public override HerculesValueType ElementType => type.Value;

        protected override HerculesValue[] CreateArrayOfValues()
        {
            var array = new HerculesValue[Elements.Length];
            
            for (var i = 0; i < array.Length; i++)
                array[i] = new HerculesValue<TValue>(Elements[i]);

            return array;
        }
    }
}