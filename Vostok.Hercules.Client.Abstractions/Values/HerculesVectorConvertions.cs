using System;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Events;

namespace Vostok.Hercules.Client.Abstractions.Values
{
    public partial class HerculesVector
    {
        /// <summary>
        /// Returns the array of values cast to <see cref="byte"/>. Requires the <see cref="ElementType"/> to have <see cref="HerculesValueType.Byte"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public byte[] AsByteArray => As<byte>();

        /// <summary>
        /// Returns the array of values cast to <see cref="short"/>. Requires the <see cref="ElementType"/> to have <see cref="HerculesValueType.Short"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public short[] AsShortArray => As<short>();

        /// <summary>
        /// Returns the array of values cast to <see cref="int"/>. Requires the <see cref="ElementType"/> to have <see cref="HerculesValueType.Int"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public int[] AsIntArray => As<int>();

        /// <summary>
        /// Returns the array of values cast to <see cref="long"/>. Requires the <see cref="ElementType"/> to have <see cref="HerculesValueType.Long"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public long[] AsLongArray => As<long>();

        /// <summary>
        /// Returns the array of values cast to <see cref="bool"/>. Requires the <see cref="ElementType"/> to have <see cref="HerculesValueType.Bool"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public bool[] AsBoolArray => As<bool>();

        /// <summary>
        /// Returns the array of values cast to <see cref="float"/>. Requires the <see cref="ElementType"/> to have <see cref="HerculesValueType.Float"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public float[] AsFloatArray => As<float>();

        /// <summary>
        /// Returns the array of values cast to <see cref="double"/>. Requires the <see cref="ElementType"/> to have <see cref="HerculesValueType.Double"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public double[] AsDoubleArray => As<double>();

        /// <summary>
        /// Returns the array of values cast to <see cref="Guid"/>. Requires the <see cref="ElementType"/> to have <see cref="HerculesValueType.Guid"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public Guid[] AsGuidArray => As<Guid>();

        /// <summary>
        /// Returns the array of values cast to <see cref="string"/>. Requires the <see cref="ElementType"/> to have <see cref="HerculesValueType.String"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        [NotNull]
        public string[] AsStringArray => As<string>();

        /// <summary>
        /// Returns the array of values cast to a vector of arbitrary <see cref="HerculesValue"/>s. Requires the <see cref="ElementType"/> to have <see cref="HerculesValueType.Vector"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        [NotNull]
        public HerculesVector[] AsVectorArray => As<HerculesVector>();

        /// <summary>
        /// Returns the array of values cast to a container of arbitrary tags (<see cref="HerculesTags"/>). Requires the <see cref="ElementType"/> to have <see cref="HerculesValueType.Container"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        [NotNull]
        public HerculesTags[] AsContainerArray => As<HerculesTags>();

        private TValue[] As<TValue>()
        {
            if (this is HerculesVector<TValue> typedVector)
                return typedVector.TypedValue;
            
            throw new InvalidCastException($"Value of vector element cannot be cast to '{nameof(TValue)}' due to being of type '{ElementType}'.");
        }
    }
}