using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Events
{
    public static partial class HerculesTagsBuilderExtensions
    {
        /// <summary>
        /// <para>Attempts to add a tag with given <paramref name="key"/> and <paramref name="value"/>.</para>
        /// <para><paramref name="value"/> representation depends on its runtime type.</para>
        /// </summary>
        /// <returns><c>true</c> when <paramref name="value"/> runtime type is natively supported by Hercules, <c>false</c> otherwise.</returns>
        public static bool TryAddObject([NotNull] this IHerculesTagsBuilder builder, [NotNull] string key, [CanBeNull] object value)
        {
            switch (value)
            {
                case string stringValue:
                    builder.AddValue(key, stringValue);
                    return true;

                case int intValue:
                    builder.AddValue(key, intValue);
                    return true;

                case long longValue:
                    builder.AddValue(key, longValue);
                    return true;

                case Guid GuidValue:
                    builder.AddValue(key, GuidValue);
                    return true;

                case bool boolValue:
                    builder.AddValue(key, boolValue);
                    return true;

                case double doubleValue:
                    builder.AddValue(key, doubleValue);
                    return true;

                case byte byteValue:
                    builder.AddValue(key, byteValue);
                    return true;

                case short shortValue:
                    builder.AddValue(key, shortValue);
                    return true;

                case float floatValue:
                    builder.AddValue(key, floatValue);
                    return true;

               case null:
                    builder.AddNull(key);
                    return true;
            }

            if (value is IEnumerable)
            {
                switch (value)
                {
                    case IReadOnlyList<string> stringList:
                        builder.AddVector(key, stringList);
                        return true;

                    case IReadOnlyList<int> intList:
                        builder.AddVector(key, intList);
                        return true;

                    case IReadOnlyList<long> longList:
                        builder.AddVector(key, longList);
                        return true;

                    case IReadOnlyList<Guid> GuidList:
                        builder.AddVector(key, GuidList);
                        return true;

                    case IReadOnlyList<bool> boolList:
                        builder.AddVector(key, boolList);
                        return true;

                    case IReadOnlyList<double> doubleList:
                        builder.AddVector(key, doubleList);
                        return true;

                    case IReadOnlyList<byte> byteList:
                        builder.AddVector(key, byteList);
                        return true;

                    case IReadOnlyList<short> shortList:
                        builder.AddVector(key, shortList);
                        return true;

                    case IReadOnlyList<float> floatList:
                        builder.AddVector(key, floatList);
                        return true;

                }
            }

            return false;
        }
    }
}