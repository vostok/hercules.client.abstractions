using System;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Events;

namespace Vostok.Hercules.Client.Abstractions.Values
{
    /// <summary>
    /// Represents any value of a tag in <see cref="HerculesTags"/>.
    /// </summary>
    [PublicAPI]
    public abstract partial class HerculesValue
    {
        /// <summary>
        /// Returns value type.
        /// </summary>
        public abstract HerculesValueType Type { get; }

        /// <summary>
        /// Returns the value itself as an <see cref="object"/>.
        /// </summary>
        public abstract object Value { get; }

        private TValue As<TValue>()
        {
            if (this is HerculesValue<TValue> typedValue)
                return typedValue.TypedValue;

            throw new InvalidCastException($"Elements of vector cannot be cast to '{nameof(TValue)}' due to being of type '{Type}'.");
        }
    }
}
