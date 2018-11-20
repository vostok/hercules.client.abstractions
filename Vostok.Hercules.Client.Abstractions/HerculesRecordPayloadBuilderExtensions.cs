using System;
using System.Collections.Generic;
using System.Linq;

namespace Vostok.Hercules.Client.Abstractions
{
    internal static class HerculesRecordPayloadBuilderExtensions
    {
        public static IHerculesRecordPayloadBuilder Add(this IHerculesRecordPayloadBuilder source, Dictionary<string, ValueHolder> tags) =>
            source.AddInternal(tags);

        public static IHerculesRecordPayloadBuilder Add(this IHerculesRecordPayloadBuilder source, string tagKey, ValueHolder tagValueHolder) =>
            source.AddInternal(tagKey, tagValueHolder);

        private static Func<IHerculesRecordPayloadBuilder, IHerculesRecordPayloadBuilder> AddInternalFunc(Dictionary<string, ValueHolder> dictionary) =>
            builder => builder.AddInternal(dictionary);

        private static IHerculesRecordPayloadBuilder AddInternal(this IHerculesRecordPayloadBuilder source, Dictionary<string, ValueHolder> dictionary) =>
            dictionary.Aggregate(source, (builder, pair) => builder.AddInternal(pair.Key, pair.Value));

        private static IHerculesRecordPayloadBuilder AddInternal(this IHerculesRecordPayloadBuilder source, string key, ValueHolder valueHolder) =>
            source.AddInternal(key, valueHolder.Value);

        private static IHerculesRecordPayloadBuilder AddInternal(this IHerculesRecordPayloadBuilder source, string key, object value)
        {
            if (value is Dictionary<string, ValueHolder>[] dictionaryArray)
            {
                return source.Add(key, dictionaryArray.Select(AddInternalFunc).ToArray());
            }

            if (value is Dictionary<string, ValueHolder> dictionary)
            {
                return source.Add(key, AddInternalFunc(dictionary));
            }

            switch (value)
            {
                case byte @byte:
                    return source.Add(key, @byte);
                case short @short:
                    return source.Add(key, @short);
                case int @int:
                    return source.Add(key, @int);
                case long @long:
                    return source.Add(key, @long);
                case bool @bool:
                    return source.Add(key, @bool);
                case float @float:
                    return source.Add(key, @float);
                case double @double:
                    return source.Add(key, @double);
                case string @string:
                    return source.Add(key, @string);
                case byte[] byteArray:
                    return source.Add(key, byteArray);
                case short[] shortArray:
                    return source.Add(key, shortArray);
                case int[] intArray:
                    return source.Add(key, intArray);
                case long[] longArray:
                    return source.Add(key, longArray);
                case bool[] boolArray:
                    return source.Add(key, boolArray);
                case float[] floatArray:
                    return source.Add(key, floatArray);
                case double[] doubleArray:
                    return source.Add(key, doubleArray);
                case string[] stringArray:
                    return source.Add(key, stringArray);
                default:
                    throw new ArgumentOutOfRangeException(nameof(value));
            }
        }
    }
}