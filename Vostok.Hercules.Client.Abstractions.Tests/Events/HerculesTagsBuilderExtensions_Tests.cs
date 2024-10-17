using System;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;
using Vostok.Hercules.Client.Abstractions.Events;

namespace Vostok.Hercules.Client.Abstractions.Tests.Events
{
    internal class HerculesTagsBuilderExtensions_Tests
    {
        [Test]
        public void AddTags_should_copy_tags_from_other_HerculesTags()
        {
            var expectedEventBuilder = new HerculesTagsBuilder();
            WriteTagsWithAllDataTypes(expectedEventBuilder);

            var expectedTags = expectedEventBuilder.BuildTags();

            var actualEventBuilder = new HerculesTagsBuilder();
            actualEventBuilder.AddTags(expectedTags);

            var actualTags = actualEventBuilder.BuildTags();

            actualTags.Equals(expectedTags).Should().BeTrue();
        }

        private void WriteTagsWithAllDataTypes(IHerculesTagsBuilder builder)
        {
            var guid = Guid.NewGuid();
            var @bool = true;
            var @byte = (byte)42;
            var @double = Math.PI;
            var @float = (float)@double;
            var @int = int.MaxValue;
            var @long = long.MinValue;
            var @short = short.MinValue;
            var @string = "dotnet";

            var guidVec = new[] {Guid.NewGuid(), Guid.NewGuid()};
            var boolVec = new[] {true, false};
            var byteVec = new[] {(byte)42, (byte)25};
            var doubleVec = new[] {Math.PI, Math.E};
            var floatVec = doubleVec.Select(x => (float)x).ToArray();
            var intVec = new[] {1337, 31337, int.MaxValue, int.MinValue};
            var longVec = new[] {long.MaxValue, long.MinValue, (long)1e18 + 1};
            var shortVec = new short[] {1000, 2000};
            var stringVec = new[] {"dotnet", "hercules"};

            builder
                .AddNull("null")
                .AddValue("guid", guid)
                .AddValue("bool", @bool)
                .AddValue("byte", @byte)
                .AddValue("double", @double)
                .AddValue("float", @float)
                .AddValue("int", @int)
                .AddValue("long", @long)
                .AddValue("short", @short)
                .AddValue("string", @string)
                .AddVector("guidVec", guidVec)
                .AddVector("boolVec", boolVec)
                .AddVector("byteVec", byteVec)
                .AddVector("doubleVec", doubleVec)
                .AddVector("floatVec", floatVec)
                .AddVector("intVec", intVec)
                .AddVector("longVec", longVec)
                .AddVector("shortVec", shortVec)
                .AddVector("stringVec", stringVec)
                .AddVector("emptyVec", new int[0])
                .AddContainer(
                    "container",
                    b => b
                        .AddValue("inner", "x")
                        .AddVector("innerVec", new[] {1, 2, 3}))
                .AddVectorOfContainers(
                    "containerVec",
                    new Action<IHerculesTagsBuilder>[]
                    {
                        b => b
                            .AddValue("inner", "y")
                            .AddVector("innerVec", new long[] {1, 3, 5})
                    })
                .AddVectorOfContainers(
                    "containerVec2",
                    new []{"a", "b", "c"},
                    (bld, s) =>  bld
                        .AddValue("inner", "z")
                        .AddValue("innerVectorValue", s))
                .AddVectorOfContainers("emptyContainerVec", new Action<IHerculesTagsBuilder>[0]);
        }
    }
}