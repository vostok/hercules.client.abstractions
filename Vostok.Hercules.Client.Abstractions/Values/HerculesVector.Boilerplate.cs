using System;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Events;

namespace Vostok.Hercules.Client.Abstractions.Values
{
    public abstract partial class HerculesVector
    {
        #region bool
        
        /// <summary>
        /// Returns <c>true</c> if this elements is of <see cref="HerculesValueType.Bool"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsVectorOfBool => this is HerculesVector<bool>;

        /// <summary>
        /// Returns the array of values cast to <see cref="bool"/>. Requires the <see cref="ElementType"/> to have <see cref="HerculesValueType.Bool"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public bool[] AsBoolArray => As<bool>();

        #endregion

        #region byte
        
        /// <summary>
        /// Returns <c>true</c> if this elements is of <see cref="HerculesValueType.Byte"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsVectorOfByte => this is HerculesVector<byte>;

        /// <summary>
        /// Returns the array of values cast to <see cref="byte"/>. Requires the <see cref="ElementType"/> to have <see cref="HerculesValueType.Byte"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public byte[] AsByteArray => As<byte>();

        #endregion

        #region short
        
        /// <summary>
        /// Returns <c>true</c> if this elements is of <see cref="HerculesValueType.Short"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsVectorOfShort => this is HerculesVector<short>;

        /// <summary>
        /// Returns the array of values cast to <see cref="short"/>. Requires the <see cref="ElementType"/> to have <see cref="HerculesValueType.Short"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public short[] AsShortArray => As<short>();

        #endregion

        #region int
        
        /// <summary>
        /// Returns <c>true</c> if this elements is of <see cref="HerculesValueType.Int"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsVectorOfInt => this is HerculesVector<int>;

        /// <summary>
        /// Returns the array of values cast to <see cref="int"/>. Requires the <see cref="ElementType"/> to have <see cref="HerculesValueType.Int"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public int[] AsIntArray => As<int>();

        #endregion

        #region long
        
        /// <summary>
        /// Returns <c>true</c> if this elements is of <see cref="HerculesValueType.Long"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsVectorOfLong => this is HerculesVector<long>;

        /// <summary>
        /// Returns the array of values cast to <see cref="long"/>. Requires the <see cref="ElementType"/> to have <see cref="HerculesValueType.Long"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public long[] AsLongArray => As<long>();

        #endregion

        #region float
        
        /// <summary>
        /// Returns <c>true</c> if this elements is of <see cref="HerculesValueType.Float"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsVectorOfFloat => this is HerculesVector<float>;

        /// <summary>
        /// Returns the array of values cast to <see cref="float"/>. Requires the <see cref="ElementType"/> to have <see cref="HerculesValueType.Float"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public float[] AsFloatArray => As<float>();

        #endregion

        #region double
        
        /// <summary>
        /// Returns <c>true</c> if this elements is of <see cref="HerculesValueType.Double"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsVectorOfDouble => this is HerculesVector<double>;

        /// <summary>
        /// Returns the array of values cast to <see cref="double"/>. Requires the <see cref="ElementType"/> to have <see cref="HerculesValueType.Double"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public double[] AsDoubleArray => As<double>();

        #endregion

        #region Guid
        
        /// <summary>
        /// Returns <c>true</c> if this elements is of <see cref="HerculesValueType.Guid"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsVectorOfGuid => this is HerculesVector<Guid>;

        /// <summary>
        /// Returns the array of values cast to <see cref="Guid"/>. Requires the <see cref="ElementType"/> to have <see cref="HerculesValueType.Guid"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public Guid[] AsGuidArray => As<Guid>();

        #endregion

        #region string
        
        /// <summary>
        /// Returns <c>true</c> if this elements is of <see cref="HerculesValueType.String"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsVectorOfString => this is HerculesVector<string>;

        /// <summary>
        /// Returns the array of values cast to <see cref="string"/>. Requires the <see cref="ElementType"/> to have <see cref="HerculesValueType.String"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public string[] AsStringArray => As<string>();

        #endregion

        #region HerculesVector
        
        /// <summary>
        /// Returns <c>true</c> if this elements is of <see cref="HerculesValueType.Vector"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsVectorOfVector => this is HerculesVector<HerculesVector>;

        /// <summary>
        /// Returns the array of values cast to <see cref="HerculesVector"/>. Requires the <see cref="ElementType"/> to have <see cref="HerculesValueType.Vector"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public HerculesVector[] AsVectorArray => As<HerculesVector>();

        #endregion

        #region HerculesTags
        
        /// <summary>
        /// Returns <c>true</c> if this elements is of <see cref="HerculesValueType.Container"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsVectorOfContainer => this is HerculesVector<HerculesTags>;

        /// <summary>
        /// Returns the array of values cast to <see cref="HerculesTags"/>. Requires the <see cref="ElementType"/> to have <see cref="HerculesValueType.Container"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public HerculesTags[] AsContainerArray => As<HerculesTags>();

        #endregion


        private TValue[] As<TValue>()
        {
            if (this is HerculesVector<TValue> typedVector)
                return typedVector.TypedValue;
            
            throw new InvalidCastException($"Value of vector element cannot be cast to '{nameof(TValue)}' due to being of type '{ElementType}'.");
        }
    }
}