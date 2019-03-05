using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Events;

namespace Vostok.Hercules.Client.Abstractions.Values
{
    public abstract partial class HerculesVector
    {
        #region bool

        /// <summary>
        /// Returns <c>true</c> if this vector's elements are of <see cref="HerculesValueType.Bool"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsVectorOfBool => this is HerculesVector<bool>;

        /// <summary>
        /// Returns a list of values cast to <see cref="bool"/>. Requires the <see cref="ElementType"/> to be <see cref="HerculesValueType.Bool"/>.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        [NotNull]
        public IReadOnlyList<bool> AsBoolList => As<bool>();

        #endregion

        #region byte

        /// <summary>
        /// Returns <c>true</c> if this vector's elements are of <see cref="HerculesValueType.Byte"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsVectorOfByte => this is HerculesVector<byte>;

        /// <summary>
        /// Returns a list of values cast to <see cref="byte"/>. Requires the <see cref="ElementType"/> to be <see cref="HerculesValueType.Byte"/>.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        [NotNull]
        public IReadOnlyList<byte> AsByteList => As<byte>();

        #endregion

        #region short

        /// <summary>
        /// Returns <c>true</c> if this vector's elements are of <see cref="HerculesValueType.Short"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsVectorOfShort => this is HerculesVector<short>;

        /// <summary>
        /// Returns a list of values cast to <see cref="short"/>. Requires the <see cref="ElementType"/> to be <see cref="HerculesValueType.Short"/>.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        [NotNull]
        public IReadOnlyList<short> AsShortList => As<short>();

        #endregion

        #region int

        /// <summary>
        /// Returns <c>true</c> if this vector's elements are of <see cref="HerculesValueType.Int"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsVectorOfInt => this is HerculesVector<int>;

        /// <summary>
        /// Returns a list of values cast to <see cref="int"/>. Requires the <see cref="ElementType"/> to be <see cref="HerculesValueType.Int"/>.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        [NotNull]
        public IReadOnlyList<int> AsIntList => As<int>();

        #endregion

        #region long

        /// <summary>
        /// Returns <c>true</c> if this vector's elements are of <see cref="HerculesValueType.Long"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsVectorOfLong => this is HerculesVector<long>;

        /// <summary>
        /// Returns a list of values cast to <see cref="long"/>. Requires the <see cref="ElementType"/> to be <see cref="HerculesValueType.Long"/>.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        [NotNull]
        public IReadOnlyList<long> AsLongList => As<long>();

        #endregion

        #region float

        /// <summary>
        /// Returns <c>true</c> if this vector's elements are of <see cref="HerculesValueType.Float"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsVectorOfFloat => this is HerculesVector<float>;

        /// <summary>
        /// Returns a list of values cast to <see cref="float"/>. Requires the <see cref="ElementType"/> to be <see cref="HerculesValueType.Float"/>.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        [NotNull]
        public IReadOnlyList<float> AsFloatList => As<float>();

        #endregion

        #region double

        /// <summary>
        /// Returns <c>true</c> if this vector's elements are of <see cref="HerculesValueType.Double"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsVectorOfDouble => this is HerculesVector<double>;

        /// <summary>
        /// Returns a list of values cast to <see cref="double"/>. Requires the <see cref="ElementType"/> to be <see cref="HerculesValueType.Double"/>.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        [NotNull]
        public IReadOnlyList<double> AsDoubleList => As<double>();

        #endregion

        #region Guid

        /// <summary>
        /// Returns <c>true</c> if this vector's elements are of <see cref="HerculesValueType.Guid"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsVectorOfGuid => this is HerculesVector<Guid>;

        /// <summary>
        /// Returns a list of values cast to <see cref="Guid"/>. Requires the <see cref="ElementType"/> to be <see cref="HerculesValueType.Guid"/>.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        [NotNull]
        public IReadOnlyList<Guid> AsGuidList => As<Guid>();

        #endregion

        #region string

        /// <summary>
        /// Returns <c>true</c> if this vector's elements are of <see cref="HerculesValueType.String"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsVectorOfString => this is HerculesVector<string>;

        /// <summary>
        /// Returns a list of values cast to <see cref="string"/>. Requires the <see cref="ElementType"/> to be <see cref="HerculesValueType.String"/>.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        [NotNull]
        public IReadOnlyList<string> AsStringList => As<string>();

        #endregion

        #region HerculesVector

        /// <summary>
        /// Returns <c>true</c> if this vector's elements are of <see cref="HerculesValueType.Vector"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsVectorOfVector => this is HerculesVector<HerculesVector>;

        /// <summary>
        /// Returns a list of values cast to <see cref="HerculesVector"/>. Requires the <see cref="ElementType"/> to be <see cref="HerculesValueType.Vector"/>.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        [NotNull]
        public IReadOnlyList<HerculesVector> AsVectorList => As<HerculesVector>();

        #endregion

        #region HerculesTags

        /// <summary>
        /// Returns <c>true</c> if this vector's elements are of <see cref="HerculesValueType.Container"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsVectorOfContainer => this is HerculesVector<HerculesTags>;

        /// <summary>
        /// Returns a list of values cast to <see cref="HerculesTags"/>. Requires the <see cref="ElementType"/> to be <see cref="HerculesValueType.Container"/>.
        /// <exception cref="InvalidCastException">The cast is not valid due to mismatching value type.</exception>
        /// </summary>
        [NotNull]
        public IReadOnlyList<HerculesTags> AsContainerList => As<HerculesTags>();

        #endregion
    }
}