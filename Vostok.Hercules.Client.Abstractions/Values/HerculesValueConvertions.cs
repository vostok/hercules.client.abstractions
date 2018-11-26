using System;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Events;

namespace Vostok.Hercules.Client.Abstractions.Values
{
    public abstract partial class HerculesValue
    {
        /// <summary>
        /// Returns the value cast to <see cref="byte"/>. Requires the value to have <see cref="HerculesValueType.Byte"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public byte AsByte => As<byte, HerculesByte>();

        /// <summary>
        /// Returns the value cast to <see cref="short"/>. Requires the value to have <see cref="HerculesValueType.Short"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public short AsShort => As<short, HerculesShort>();

        /// <summary>
        /// Returns the value cast to <see cref="int"/>. Requires the value to have <see cref="HerculesValueType.Int"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public int AsInt => As<int, HerculesInt>();

        /// <summary>
        /// Returns the value cast to <see cref="long"/>. Requires the value to have <see cref="HerculesValueType.Long"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public long AsLong => As<long, HerculesLong>();

        /// <summary>
        /// Returns the value cast to <see cref="bool"/>. Requires the value to have <see cref="HerculesValueType.Bool"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public bool AsBool => As<bool, HerculesBool>();

        /// <summary>
        /// Returns the value cast to <see cref="float"/>. Requires the value to have <see cref="HerculesValueType.Float"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public float AsFloat => As<float, HerculesFloat>();

        /// <summary>
        /// Returns the value cast to <see cref="double"/>. Requires the value to have <see cref="HerculesValueType.Double"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public double AsDouble => As<double, HerculesDouble>();

        /// <summary>
        /// Returns the value cast to <see cref="Guid"/>. Requires the value to have <see cref="HerculesValueType.Guid"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public Guid AsGuid => As<Guid, HerculesGuid>();

        /// <summary>
        /// Returns the value cast to <see cref="string"/>. Requires the value to have <see cref="HerculesValueType.String"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        [NotNull]
        public string AsString => As<string, HerculesString>();

        /// <summary>
        /// Returns the value cast to an array of arbitrary <see cref="HerculesValue"/>s. Requires the value to have <see cref="HerculesValueType.Array"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        [NotNull]
        public HerculesValue[] AsArray => As<HerculesValue[], HerculesArray>();

        /// <summary>
        /// Returns the value cast to a container of arbitrary tags (<see cref="HerculesTags"/>). Requires the value to have <see cref="HerculesValueType.Container"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        [NotNull]
        public HerculesTags AsContainer => As<HerculesTags, HerculesContainer>();

        private TValue As<TValue, TImpl>()
            where TImpl : HerculesValue<TValue>
        {
            var implementation = this as TImpl;
            if (implementation == null)
                throw new InvalidCastException($"Current value cannot be cast to '{nameof(TValue)}' due to being of type '{Type}'.");

            return implementation.TypedValue;
        }
    }
}