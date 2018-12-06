using System;
using Vostok.Hercules.Client.Abstractions.Events;

namespace Vostok.Hercules.Client.Abstractions.Values
{
    public abstract partial class HerculesValue
    {
        #region bool

        /// <summary>
        /// Returns <c>true</c> if this value is of <see cref="HerculesValueType.Bool"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsBool => this is HerculesValue<bool>;

        /// <summary>
        /// Returns the value cast to <see cref="bool>"/>. Requires the value to have <see cref="HerculesValueType.Bool"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public bool AsBool => As<bool>();

        #endregion

        #region byte

        /// <summary>
        /// Returns <c>true</c> if this value is of <see cref="HerculesValueType.Byte"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsByte => this is HerculesValue<byte>;

        /// <summary>
        /// Returns the value cast to <see cref="byte>"/>. Requires the value to have <see cref="HerculesValueType.Byte"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public byte AsByte => As<byte>();

        #endregion

        #region short

        /// <summary>
        /// Returns <c>true</c> if this value is of <see cref="HerculesValueType.Short"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsShort => this is HerculesValue<short>;

        /// <summary>
        /// Returns the value cast to <see cref="short>"/>. Requires the value to have <see cref="HerculesValueType.Short"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public short AsShort => As<short>();

        #endregion

        #region int

        /// <summary>
        /// Returns <c>true</c> if this value is of <see cref="HerculesValueType.Int"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsInt => this is HerculesValue<int>;

        /// <summary>
        /// Returns the value cast to <see cref="int>"/>. Requires the value to have <see cref="HerculesValueType.Int"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public int AsInt => As<int>();

        #endregion

        #region long

        /// <summary>
        /// Returns <c>true</c> if this value is of <see cref="HerculesValueType.Long"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsLong => this is HerculesValue<long>;

        /// <summary>
        /// Returns the value cast to <see cref="long>"/>. Requires the value to have <see cref="HerculesValueType.Long"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public long AsLong => As<long>();

        #endregion

        #region float

        /// <summary>
        /// Returns <c>true</c> if this value is of <see cref="HerculesValueType.Float"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsFloat => this is HerculesValue<float>;

        /// <summary>
        /// Returns the value cast to <see cref="float>"/>. Requires the value to have <see cref="HerculesValueType.Float"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public float AsFloat => As<float>();

        #endregion

        #region double

        /// <summary>
        /// Returns <c>true</c> if this value is of <see cref="HerculesValueType.Double"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsDouble => this is HerculesValue<double>;

        /// <summary>
        /// Returns the value cast to <see cref="double>"/>. Requires the value to have <see cref="HerculesValueType.Double"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public double AsDouble => As<double>();

        #endregion

        #region Guid

        /// <summary>
        /// Returns <c>true</c> if this value is of <see cref="HerculesValueType.Guid"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsGuid => this is HerculesValue<Guid>;

        /// <summary>
        /// Returns the value cast to <see cref="Guid>"/>. Requires the value to have <see cref="HerculesValueType.Guid"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public Guid AsGuid => As<Guid>();

        #endregion

        #region string

        /// <summary>
        /// Returns <c>true</c> if this value is of <see cref="HerculesValueType.String"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsString => this is HerculesValue<string>;

        /// <summary>
        /// Returns the value cast to <see cref="string>"/>. Requires the value to have <see cref="HerculesValueType.String"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public string AsString => As<string>();

        #endregion

        #region HerculesVector

        /// <summary>
        /// Returns <c>true</c> if this value is of <see cref="HerculesValueType.Vector"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsVector => this is HerculesValue<HerculesVector>;

        /// <summary>
        /// Returns the value cast to <see cref="HerculesVector>"/>. Requires the value to have <see cref="HerculesValueType.Vector"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public HerculesVector AsVector => As<HerculesVector>();

        #endregion

        #region HerculesTags

        /// <summary>
        /// Returns <c>true</c> if this value is of <see cref="HerculesValueType.Container"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsContainer => this is HerculesValue<HerculesTags>;

        /// <summary>
        /// Returns the value cast to <see cref="HerculesTags>"/>. Requires the value to have <see cref="HerculesValueType.Container"/> type.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        public HerculesTags AsContainer => As<HerculesTags>();

        #endregion


        private TValue As<TValue>()
        {
            if (this is HerculesValue<TValue> typedValue)
                return typedValue.TypedValue;
            
            throw new InvalidCastException($"Elements of vector cannot be cast to '{nameof(TValue)}' due to being of type '{Type}'.");
        }
    }
}