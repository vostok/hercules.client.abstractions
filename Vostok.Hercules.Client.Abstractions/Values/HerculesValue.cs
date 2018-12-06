using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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
    }


    public abstract partial class HerculesValue
    {
        private static readonly Dictionary<Type, HerculesValueType> typeMapping = new Dictionary<Type, HerculesValueType>
        {
            [typeof(bool)] = HerculesValueType.Bool,
            [typeof(byte)] = HerculesValueType.Byte,
            [typeof(short)] = HerculesValueType.Short,
            [typeof(int)] = HerculesValueType.Int,
            [typeof(long)] = HerculesValueType.Long,
            [typeof(Guid)] = HerculesValueType.Guid,
            [typeof(float)] = HerculesValueType.Float,
            [typeof(double)] = HerculesValueType.Double,
            [typeof(string)] = HerculesValueType.String,
            [typeof(HerculesVector)] = HerculesValueType.Vector,
            [typeof(HerculesTags)] = HerculesValueType.Container
        };
        
        private TValue As<TValue>()
        {
            if (this is HerculesValue<TValue> typedValue)
                return typedValue.TypedValue;
            
            throw new InvalidCastException($"Elements of vector cannot be cast to '{nameof(TValue)}' due to being of type '{Type}'.");
        }

        internal static HerculesValueType? TryMapToHerculesType(Type type)
            => typeMapping.TryGetValue(type, out var herculesType) ? herculesType as HerculesValueType? : null;

        internal static HerculesValueType GetHerculesType(Type type)
        {
            var herculesType = TryMapToHerculesType(type);
            
            if (herculesType == null)
                ThrowNotSupportedException(type);
            
            // ReSharper disable once PossibleInvalidOperationException
            return herculesType.Value;
        }
        
        internal static bool IsSupported(Type type)
            => typeMapping.ContainsKey(type);
        
        internal static HerculesValueType ThrowNotSupportedException(Type type)
            => throw new NotSupportedException($"Type '{type.FullName}' cannot be mapped to Hercules value type.");
    }
}
