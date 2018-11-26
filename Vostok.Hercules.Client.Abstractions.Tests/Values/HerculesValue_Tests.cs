using System;
using System.Linq;
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
            var allValueTypes = Enum.GetValues(typeof(HerculesValueType)).Cast<HerculesValueType>().ToArray();

            var allImplementedTypes = GetAllImplementations().Select(v => v.Type);

            allImplementedTypes.Should().BeEquivalentTo(allValueTypes);
        }

        private static Type[] GetAllImplementationTypes()
        {
            return typeof(HerculesValue).Assembly
                .GetTypes()
                .Where(type => typeof(HerculesValue).IsAssignableFrom(type))
                .Where(type => !type.IsAbstract)
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