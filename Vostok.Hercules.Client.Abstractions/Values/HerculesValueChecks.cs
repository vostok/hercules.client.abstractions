namespace Vostok.Hercules.Client.Abstractions.Values
{
    public abstract partial class HerculesValue
    {
        /// <summary>
        /// Returns <c>true</c> if this value is of <see cref="HerculesValueType.Byte"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsByte => this is HerculesByte;

        /// <summary>
        /// Returns <c>true</c> if this value is of <see cref="HerculesValueType.Short"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsShort => this is HerculesShort;

        /// <summary>
        /// Returns <c>true</c> if this value is of <see cref="HerculesValueType.Int"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsInt => this is HerculesInt;

        /// <summary>
        /// Returns <c>true</c> if this value is of <see cref="HerculesValueType.Long"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsLong => this is HerculesLong;

        /// <summary>
        /// Returns <c>true</c> if this value is of <see cref="HerculesValueType.Bool"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsBool => this is HerculesBool;

        /// <summary>
        /// Returns <c>true</c> if this value is of <see cref="HerculesValueType.Float"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsFloat => this is HerculesFloat;

        /// <summary>
        /// Returns <c>true</c> if this value is of <see cref="HerculesValueType.Double"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsDouble => this is HerculesDouble;

        /// <summary>
        /// Returns <c>true</c> if this value is of <see cref="HerculesValueType.Guid"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsGuid => this is HerculesGuid;

        /// <summary>
        /// Returns <c>true</c> if this value is of <see cref="HerculesValueType.String"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsString => this is HerculesString;

        /// <summary>
        /// Returns <c>true</c> if this value is of <see cref="HerculesValueType.Vector"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsVector => this is HerculesVectorHolder;

        /// <summary>
        /// Returns <c>true</c> if this value is of <see cref="HerculesValueType.Container"/> type, or <c>false</c> otherwise.
        /// </summary>
        public bool IsContainer => this is HerculesContainer;
    }
}