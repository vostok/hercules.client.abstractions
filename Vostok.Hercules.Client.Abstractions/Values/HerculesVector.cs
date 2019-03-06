using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Events;

namespace Vostok.Hercules.Client.Abstractions.Values
{
    /// <summary>
    /// Represents a vector of values of same type in <see cref="HerculesTags"/>.
    /// </summary>
    [PublicAPI]
    public abstract partial class HerculesVector
    {
        /// <summary>
        /// Returns <see cref="HerculesValueType"/> of vector elements.
        /// </summary>
        public abstract HerculesValueType ElementType { get; }

        /// <summary>
        /// Returns elements of the vector as a sequence of <see cref="HerculesValue"/>s.
        /// </summary>
        public abstract IEnumerable<HerculesValue> Elements { get; }

        /// <summary>
        /// Returns elements count in this vector.
        /// </summary>
        public abstract int Count { get; }

        public override string ToString() => HerculesTagsRenderer.Render(this);

        private IReadOnlyList<TValue> As<TValue>()
        {
            if (this is HerculesVector<TValue> typedVector)
                return typedVector.TypedElements;

            throw new InvalidCastException($"Value of vector element cannot be cast to '{typeof(TValue)}' due to being of type '{ElementType}'.");
        }
    }
}