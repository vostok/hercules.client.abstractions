using System;
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
        private HerculesValue[] valuesArray;

        /// <summary>
        /// Returns elements of vector as array of <see cref="HerculesValue"/>.
        /// </summary>
        public HerculesValue[] AsHerculesValueArray => valuesArray ?? (valuesArray = CreateArrayOfValues());
        
        /// <summary>
        /// Returns <see cref="HerculesValueType"/> of vector elements.
        /// </summary>
        public abstract HerculesValueType ElementType { get; }

        protected abstract HerculesValue[] CreateArrayOfValues();

        private TValue[] As<TValue>()
        {
            if (this is HerculesVector<TValue> typedVector)
                return typedVector.Elements;
            
            throw new InvalidCastException($"Value of vector element cannot be cast to '{nameof(TValue)}' due to being of type '{ElementType}'.");
        }
    }
}