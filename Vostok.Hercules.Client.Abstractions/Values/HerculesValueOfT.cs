using System.Diagnostics;

// ReSharper disable PossibleInvalidOperationException

namespace Vostok.Hercules.Client.Abstractions.Values
{
    [DebuggerDisplay("{" + nameof(TypedValue) + "}")]
    internal class HerculesValue<TValue> : HerculesValue
    {
        private static readonly HerculesValueType? type = HerculesValueHelpers.TryMapToHerculesType(typeof(TValue));
        
        public HerculesValue(TValue value)
        {
            if (type == null)
                HerculesValueHelpers.ThrowNotSupportedException(typeof(TValue));
            
            TypedValue = value;
        }

        public TValue TypedValue { get; }

        public override HerculesValueType Type => type.Value;
        
        public override object Value => TypedValue;
    }

}