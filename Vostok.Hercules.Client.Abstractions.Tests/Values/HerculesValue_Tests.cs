using System;
using System.Linq;
using System.Reflection;
using FluentAssertions;
using NUnit.Framework;
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

                checkProperty.Should().NotBeNull($"Is{valueType} should not be null");

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

        [Test]
        public void Value_property_should_unwrap_nulls()
        {
            var value = new HerculesValue<HerculesNull>(HerculesNull.Instance);

            value.Value.Should().BeNull();
        }

        [Test]
        public void Value_property_should_unwrap_vectors()
        {
            var value = new HerculesValue<HerculesVector>(new HerculesVector<int>(new [] {1, 2, 3}));

            value.Value.Should().BeEquivalentTo(new [] {1, 2, 3});
        }

        [Test]
        public void Value_property_should_unwrap_simple_typed_values()
        {
            var value = new HerculesValue<int>(150);

            value.Value.Should().Be(150);
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
            return HerculesValueTypesMapping.TryMap(type) ?? throw new ArgumentException($"Unknown Hercules value type: '{type}'", nameof(type));
        }
    }
}