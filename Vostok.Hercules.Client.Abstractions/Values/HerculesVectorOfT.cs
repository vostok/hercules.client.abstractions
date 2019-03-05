using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

// ReSharper disable PossibleInvalidOperationException

namespace Vostok.Hercules.Client.Abstractions.Values
{
    internal class HerculesVector<TValue> : HerculesVector, IEquatable<HerculesVector<TValue>>
    {
        private static readonly HerculesValueType? type = HerculesValueTypesMapping.TryMap(typeof(TValue));

        public HerculesVector([NotNull] IReadOnlyList<TValue> elements)
        {
            if (type == null)
                HerculesValueTypesMapping.ThrowNotSupportedException(typeof(TValue));

            TypedElements = elements ?? throw new ArgumentNullException(nameof(elements));
        }

        [NotNull]
        public IReadOnlyList<TValue> TypedElements { get; }

        public override HerculesValueType ElementType => type.Value;

        public override IEnumerable<HerculesValue> Elements
            => TypedElements.Select(element => new HerculesValue<TValue>(element));

        public override int Count => TypedElements.Count;

        #region Equality

        public bool Equals(HerculesVector<TValue> other)
        {
            if (other == null)
                return false;

            if (ReferenceEquals(this, other))
                return true;

            if (TypedElements.Count != other.TypedElements.Count)
                return false;

            return TypedElements.SequenceEqual(other.TypedElements);
        }

        public override bool Equals(object other)
            => Equals(other as HerculesVector<TValue>);

        public override int GetHashCode()
        {
            unchecked
            {
                return TypedElements.Aggregate(TypedElements.Count, (current, element) => current * 397 ^ (element?.GetHashCode() ?? 0));
            }
        }

        #endregion
    }
}