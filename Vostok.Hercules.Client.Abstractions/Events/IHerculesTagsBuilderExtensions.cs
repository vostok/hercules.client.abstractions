using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Values;

namespace Vostok.Hercules.Client.Abstractions.Events
{
    /// <summary>
    /// A set of extensions for <see cref="IHerculesTagsBuilder"/>.
    /// </summary>
    [PublicAPI]
    public static partial class HerculesTagsBuilderExtensions
    {
        /// <summary>
        /// <para>Adds a tag that represents an array of containers with given <paramref name="key"/> and container values built from given <paramref name="values"/> via <paramref name="valueBuilder"/> delegate.</para>
        /// <para>Conflict resolution (behaviour when a tag with such name already exists) is implementation-specific.</para>
        /// <para>Returned value is utilized solely for the purpose of fluent syntax (chaining calls) and should not return a different instance of <see cref="IHerculesTagsBuilder"/>.</para>
        /// </summary>
        [NotNull]
        public static IHerculesTagsBuilder AddVectorOfContainers<TValue>(
            [NotNull] this IHerculesTagsBuilder builder,
            [NotNull] string key,
            [NotNull] IReadOnlyList<TValue> values,
            [NotNull] Action<IHerculesTagsBuilder, TValue> valueBuilder)
            => builder.AddVectorOfContainers(
                key,
                values.Select(x => new Action<IHerculesTagsBuilder>(b => valueBuilder(b, x))).ToArray());

        /// <summary>
        /// <para>Adds a tag that represents an existing <see cref="HerculesVector"/> <paramref name="vector"/> with given <paramref name="key"/> and container values to <paramref name="builder"/>.</para>
        /// <para>Conflict resolution (behaviour when a tag with such name already exists) is implementation-specific.</para>
        /// <para>Returned value is utilized solely for the purpose of fluent syntax (chaining calls) and should not return a different instance of <see cref="IHerculesTagsBuilder"/>.</para>
        /// </summary>
        /// <returns></returns>
        [NotNull]
        public static IHerculesTagsBuilder AddVector(this IHerculesTagsBuilder builder, string key, HerculesVector vector)
        {
            switch (vector.ElementType)
            {
                case HerculesValueType.Byte:
                    builder.AddVector(key, vector.AsByteList);
                    break;
                case HerculesValueType.Short:
                    builder.AddVector(key, vector.AsShortList);
                    break;
                case HerculesValueType.Int:
                    builder.AddVector(key, vector.AsIntList);
                    break;
                case HerculesValueType.Long:
                    builder.AddVector(key, vector.AsLongList);
                    break;
                case HerculesValueType.Bool:
                    builder.AddVector(key, vector.AsBoolList);
                    break;
                case HerculesValueType.Float:
                    builder.AddVector(key, vector.AsFloatList);
                    break;
                case HerculesValueType.Double:
                    builder.AddVector(key, vector.AsDoubleList);
                    break;
                case HerculesValueType.Guid:
                    builder.AddVector(key, vector.AsGuidList);
                    break;
                case HerculesValueType.String:
                    builder.AddVector(key, vector.AsStringList);
                    break;
                case HerculesValueType.Vector:
                    throw new NotImplementedException("Support of nested vectors is not implemented.");
                case HerculesValueType.Container:
                    builder.AddVectorOfContainers(key, vector.AsContainerList, (tagsBuilder, tags) => tagsBuilder.AddTags(tags));
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            
            return builder;
        }
        
        /// <summary>
        /// <para>Adds tags from existing <see cref="HerculesTags"/> <paramref name="tags"/> to <paramref name="builder"/>.</para>
        /// <para>Conflict resolution (behaviour when a tag with such name already exists) is implementation-specific.</para>
        /// <para>Returned value is utilized solely for the purpose of fluent syntax (chaining calls) and should not return a different instance of <see cref="IHerculesTagsBuilder"/>.</para>
        /// </summary>
        /// <returns></returns>
        [NotNull]
        public static IHerculesTagsBuilder AddTags(this IHerculesTagsBuilder builder, HerculesTags tags)
        {
            foreach (var tag in tags)
            {
                var key = tag.Key;
                var value = tag.Value;
                
                switch (value.Type)
                {
                    case HerculesValueType.Byte:
                        builder.AddValue(key, value.AsByte);
                        break;
                    case HerculesValueType.Short:
                        builder.AddValue(key, value.AsShort);
                        break;
                    case HerculesValueType.Int:
                        builder.AddValue(key, value.AsInt);
                        break;
                    case HerculesValueType.Long:
                        builder.AddValue(key, value.AsShort);
                        break;
                    case HerculesValueType.Bool:
                        builder.AddValue(key, value.AsBool);
                        break;
                    case HerculesValueType.Float:
                        builder.AddValue(key, value.AsFloat);
                        break;
                    case HerculesValueType.Double:
                        builder.AddValue(key, value.AsDouble);
                        break;
                    case HerculesValueType.Guid:
                        builder.AddValue(key, value.AsGuid);
                        break;
                    case HerculesValueType.String:
                        builder.AddValue(key, value.AsString);
                        break;
                    case HerculesValueType.Vector:
                        builder.AddVector(key, value.AsVector);
                        break;
                    case HerculesValueType.Container:
                        builder.AddContainer(key, tagsBuilder => tagsBuilder.AddTags(value.AsContainer));
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(value.Type), value.Type, "Unknown tag type.");
                }
            }
            
            return builder;
        }
    }
}
