using System;
using System.Collections.Generic;
using System.Linq;
using Vostok.Hercules.Client.Abstractions.Events;

namespace Vostok.Hercules.Client.Abstractions.Values
{
    internal static class HerculesValueTypesMapping
    {
        private static readonly Dictionary<Type, HerculesValueType> Mapping = new Dictionary<Type, HerculesValueType>
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
            = Mapping.ToDictionary(pair => pair.Value, pair => pair.Key);

        public static HerculesValueType? TryMap(Type type)
            => Mapping.TryGetValue(type, out var result) ? result as HerculesValueType? : null;

        public static Type TryMap(HerculesValueType type)
            => ReverseMapping.TryGetValue(type, out var result) ? result : null;

        public static HerculesValueType ThrowNotSupportedException(Type type)
            => throw new NotSupportedException($"Type '{type.Name}' cannot be mapped to Hercules value type.");
    }
}