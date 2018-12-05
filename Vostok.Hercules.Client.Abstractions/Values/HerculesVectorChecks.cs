using System;
using Vostok.Hercules.Client.Abstractions.Events;

namespace Vostok.Hercules.Client.Abstractions.Values
{
    public abstract partial class HerculesVector
    {
        /// <summary>
        /// Returns <c>true</c> if this elements is of <see cref="HerculesValueType.Byte"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsVectorOfByte => this is HerculesVector<byte>;

        /// <summary>
        /// Returns <c>true</c> if this elements is of <see cref="HerculesValueType.Short"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsVectorOfShort => this is HerculesVector<short>;

        /// <summary>
        /// Returns <c>true</c> if this elements is of <see cref="HerculesValueType.Int"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsVectorOfInt => this is HerculesVector<int>;

        /// <summary>
        /// Returns <c>true</c> if this elements is of <see cref="HerculesValueType.Long"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsVectorOfLong => this is HerculesVector<long>;

        /// <summary>
        /// Returns <c>true</c> if this elements is of <see cref="HerculesValueType.Bool"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsVectorOfBool => this is HerculesVector<bool>;

        /// <summary>
        /// Returns <c>true</c> if this elements is of <see cref="HerculesValueType.Float"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsVectorOfFloat => this is HerculesVector<float>;

        /// <summary>
        /// Returns <c>true</c> if this elements is of <see cref="HerculesValueType.Double"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsVectorOfDouble => this is HerculesVector<double>;

        /// <summary>
        /// Returns <c>true</c> if this elements is of <see cref="HerculesValueType.Guid"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsVectorOfGuid => this is HerculesVector<Guid>;

        /// <summary>
        /// Returns <c>true</c> if this elements is of <see cref="HerculesValueType.String"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsVectorOfString => this is HerculesVector<string>;

        /// <summary>
        /// Returns <c>true</c> if this elements is of <see cref="HerculesValueType.Vector"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsVectorOfVector => this is HerculesVector<HerculesVector>;

        /// <summary>
        /// Returns <c>true</c> if this elements is of <see cref="HerculesValueType.Container"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsVectorOfContainer => this is HerculesVector<HerculesTags>;
    }
}