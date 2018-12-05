using System;
using System.Linq;
using System.Reflection;
using FluentAssertions;
using NUnit.Framework;
using Vostok.Hercules.Client.Abstractions.Events;
using Vostok.Hercules.Client.Abstractions.Values;

namespace Vostok.Hercules.Client.Abstractions.Tests.Values
{
    [TestFixture]
    internal class HerculesValue_Tests
    {
        [Test]
        public void There_should_be_a_check_property_for_each_of_value_types()
        {
            var allValueTypes = GetAllValueTypes();

            var allImplementations = GetAllImplementations();

            foreach (var valueType in allValueTypes)
            {
                var checkProperty = typeof(HerculesValue).GetProperty($"Is{valueType}", BindingFlags.Public | BindingFlags.Instance);

                checkProperty.Should().NotBeNull();

                var implementation = allImplementations.Single(impl => impl.Type == valueType);

                checkProperty.GetMethod.Invoke(implementation, new object[] {}).Should().Be(true);
            }
        }

        [Test]
        public void There_should_be_a_conversion_property_for_each_of_value_types()
        {
            var allValueTypes = GetAllValueTypes();

            var allImplementations = GetAllImplementations();

            foreach (var valueType in allValueTypes)
            {
                var conversionProperty = typeof(HerculesValue).GetProperty($"As{valueType}", BindingFlags.Public | BindingFlags.Instance);

                conversionProperty.Should().NotBeNull();

                var implementation = allImplementations.Single(impl => impl.Type == valueType);

                conversionProperty.GetMethod.Invoke(implementation, new object[] {});
            }
        }

        private static HerculesValueType[] GetAllValueTypes()
        {
            return Enum
                .GetValues(typeof(HerculesValueType))
                .Cast<HerculesValueType>()
                .ToArray();
        }

        private static Type[] GetAllImplementationTypes()
        {
            return Enum.GetValues(typeof(HerculesValueType))
                .Cast<HerculesValueType>()
                .Select(GetTypeByHerculesType)
                .Select(x => typeof(HerculesValue<>).MakeGenericType(x))
                .ToArray();
        }

        private static HerculesValue[] GetAllImplementations()
        {
            return GetAllImplementationTypes()
                .Select(type => Activator.CreateInstance(type, CreateDefaultValue(type.GetProperty("TypedValue").PropertyType)))
                .Cast<HerculesValue>()
                .ToArray();
        }

        private static object CreateDefaultValue(Type type)
        {
            return type.IsValueType ? Activator.CreateInstance(type) : null;
        }

        private static Type GetTypeByHerculesType(HerculesValueType type)
        {
            switch (type)
            {
                case HerculesValueType.Byte:
                    return typeof(byte);
                case HerculesValueType.Short:
                    return typeof(short);
                case HerculesValueType.Int:
                    return typeof(int);
                case HerculesValueType.Long:
                    return typeof(long);
                case HerculesValueType.Bool:
                    return typeof(bool);
                case HerculesValueType.Float:
                    return typeof(float);
                case HerculesValueType.Double:
                    return typeof(double);
                case HerculesValueType.Guid:
                    return typeof(Guid);
                case HerculesValueType.String:
                    return typeof(string);
                case HerculesValueType.Vector:
                    return typeof(HerculesVector);
                case HerculesValueType.Container:
                    return typeof(HerculesTags);
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}