using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Events;

namespace Vostok.Hercules.Client.Abstractions.Values
{
    /// <summary>
    /// Represents a vector of values of same type in <see cref="HerculesTags"/>.
    /// </summary>
    [PublicAPI]
    public class HerculesVector
    {
        internal HerculesVector(HerculesValue[] value, HerculesValueType elementType)
        {
            Value = value;
            ElementType = elementType;
        }
        
        /// <summary>
        /// Returns elements of vector as array of <see cref="HerculesValue"/>.
        /// </summary>
        public HerculesValue[] Value { get; }
        
        /// <summary>
        /// Returns <see cref="HerculesValueType"/> of vector elements.
        /// </summary>
        public HerculesValueType ElementType { get; }
    }
}