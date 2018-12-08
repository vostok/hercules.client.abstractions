using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Events;

namespace Vostok.Hercules.Client.Abstractions.Values
{
    internal static class HerculesValueHelpers
    {
        private static readonly Dictionary<Type, HerculesValueType> TypeMapping = new Dictionary<Type, HerculesValueType>
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
            [typeof(HerculesTags)] = HerculesValueType.Container,
            [typeof(HerculesNull)] = HerculesValueType.Null
        };

        private static readonly Dictionary<HerculesValueType, Type> ReverseMapping
            = TypeMapping.ToDictionary(pair => pair.Value, pair => pair.Key);

        public static HerculesValueType? TryMapToHerculesType(Type type)
            => TypeMapping.TryGetValue(type, out var herculesType) ? herculesType as HerculesValueType? : null;

        public static Type TryMapToRuntimeType(HerculesValueType type)
            => ReverseMapping.TryGetValue(type, out var runtimeType) ? runtimeType : null;

        public static HerculesValueType ThrowNotSupportedException(Type type)
            => throw new NotSupportedException($"Type '{type.Name}' cannot be mapped to Hercules value type.");

        [CanBeNull]
        public static object UnwrapValue<T>(HerculesValue<T> value)
        {
            if (value.IsNull)
                return null;

            if (value.IsVector)
                return value.AsVector.Elements.Select(element => element.Value);

            return value.TypedValue;
        }
    }
}
