using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

// ReSharper disable PossibleInvalidOperationException

namespace Vostok.Hercules.Client.Abstractions.Values
{
    [DebuggerDisplay("{" + nameof(TypedValue) + "}")]
    internal class HerculesValue<TValue> : HerculesValue, IEquatable<HerculesValue<TValue>>
    {
        private static readonly HerculesValueType? type = HerculesValueTypesMapping.TryMap(typeof(TValue));

        public HerculesValue(TValue value)
        {
            if (type == null)
                HerculesValueTypesMapping.ThrowNotSupportedException(typeof(TValue));

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

        public override string ToString() =>
            TypedValue?.ToString() ?? string.Empty;

        #region Equality

        public bool Equals(HerculesValue<TValue> other)
        {
            if (other == null)
                return false;

            if (ReferenceEquals(this, other))
                return true;

            return Equals(TypedValue, other.TypedValue);
        }

        public override bool Equals(object other)
            => Equals(other as HerculesValue<TValue>);

        public override int GetHashCode() 
            => TypedValue?.GetHashCode() ?? 0;

        #endregion
    }
}