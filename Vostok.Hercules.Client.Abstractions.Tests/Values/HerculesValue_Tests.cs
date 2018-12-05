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
        public void There_should_be_an_implementation_for_each_of_value_types()
        {
            var allValueTypes = GetAllValueTypes();

            var allImplementedTypes = GetAllImplementations().Select(v => v.Type);

            allImplementedTypes.Should().BeEquivalentTo(allValueTypes);
        }

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
                .Where(x => x != HerculesValueType.Vector)
                .ToArray();
        }

        private static Type[] GetAllImplementationTypes()
        {
            return typeof(HerculesValue).Assembly
                .GetTypes()
                .Where(type => typeof(HerculesValue).IsAssignableFrom(type))
                .Where(type => !type.IsAbstract)
                .Where(type => type != typeof(HerculesVector))
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
    }
}