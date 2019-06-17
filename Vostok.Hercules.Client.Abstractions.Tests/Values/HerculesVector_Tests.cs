using System;
using FluentAssertions;
using NUnit.Framework;
using Vostok.Hercules.Client.Abstractions.Values;

namespace Vostok.Hercules.Client.Abstractions.Tests.Values
{
    internal class HerculesVector_Tests
    {
        [Test]
        public void Should_have_target_type_name_in_InvalidCastException_message_thrown_by_As_method()
        {
            var value = new HerculesVector<int>(new[] {1, 2, 3});

            new Action(() => value.AsLongList.GetHashCode())
                .Should()
                .Throw<InvalidCastException>()
                .Where(x => x.Message.Contains(typeof(long).ToString()));
        }
    }
}