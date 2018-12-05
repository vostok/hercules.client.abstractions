using System;
using Vostok.Hercules.Client.Abstractions.Events;

namespace Vostok.Hercules.Client.Abstractions.Values
{
    public abstract partial class HerculesValue
    {
        /// <summary>
        /// Returns <c>true</c> if this value is of <see cref="HerculesValueType.Byte"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsByte => this is HerculesValue<byte>;

        /// <summary>
        /// Returns <c>true</c> if this value is of <see cref="HerculesValueType.Short"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsShort => this is HerculesValue<short>;

        /// <summary>
        /// Returns <c>true</c> if this value is of <see cref="HerculesValueType.Int"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsInt => this is HerculesValue<int>;

        /// <summary>
        /// Returns <c>true</c> if this value is of <see cref="HerculesValueType.Long"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsLong => this is HerculesValue<long>;

        /// <summary>
        /// Returns <c>true</c> if this value is of <see cref="HerculesValueType.Bool"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsBool => this is HerculesValue<bool>;

        /// <summary>
        /// Returns <c>true</c> if this value is of <see cref="HerculesValueType.Float"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsFloat => this is HerculesValue<float>;

        /// <summary>
        /// Returns <c>true</c> if this value is of <see cref="HerculesValueType.Double"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsDouble => this is HerculesValue<double>;

        /// <summary>
        /// Returns <c>true</c> if this value is of <see cref="HerculesValueType.Guid"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsGuid => this is HerculesValue<Guid>;

        /// <summary>
        /// Returns <c>true</c> if this value is of <see cref="HerculesValueType.String"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsString => this is HerculesValue<string>;

        /// <summary>
        /// Returns <c>true</c> if this value is of <see cref="HerculesValueType.Vector"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsVector => this is HerculesValue<HerculesVector>;

        /// <summary>
        /// Returns <c>true</c> if this value is of <see cref="HerculesValueType.Container"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsContainer => this is HerculesValue<HerculesTags>;
    }
}