using System;
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
            var builder1 = new HerculesTagsBuilder();
            builder1
                .AddValue("int", 1)
                .AddVector("vec", new[] {2, 3, 4})
                .AddContainer("tags", builder => builder.AddValue("v", 1))
                .AddVectorOfContainers("tags-vec", new Action<IHerculesTagsBuilder>[] {b => b.AddValue("v", 2)});

            var tags1 = builder1.BuildTags();

            var builder2 = new HerculesTagsBuilder();
            builder2.AddTags(tags1);
            var tags2 = builder2.BuildTags();

            tags2["int"].AsInt.Should().Be(1);
            tags2["vec"].AsVector.AsIntList.Should().BeEquivalentTo(new[] {2, 3, 4}, c => c.WithStrictOrdering());
            tags2["tags"].AsContainer["v"].AsInt.Should().Be(1);
            tags2["tags-vec"].AsVector.AsContainerList[0]["v"].AsInt.Should().Be(2);
        }
    }
}