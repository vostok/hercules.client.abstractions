using System;
using System.Collections.Generic;
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
            [typeof(HerculesTags)] = HerculesValueType.Container
        };

        public static HerculesValueType? TryMapToHerculesType(Type type)
            => TypeMapping.TryGetValue(type, out var herculesType) ? herculesType as HerculesValueType? : null;

        public static HerculesValueType ThrowNotSupportedException(Type type)
            => throw new NotSupportedException($"Type '{type.FullName}' cannot be mapped to Hercules value type.");
    }
}