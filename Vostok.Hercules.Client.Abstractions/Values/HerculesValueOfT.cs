using System.Diagnostics;
using System.Linq;

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

        public override object Value
        {
            get
            {
                if (IsNull)
                    return null;

                if (IsVector)
                    return AsVector.Elements.Select(element => element.Value);

                return TypedValue;
            }
        }
    }
}