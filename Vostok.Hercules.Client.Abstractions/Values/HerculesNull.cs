using System;
using JetBrains.Annotations;

namespace Vostok.Hercules.Client.Abstractions.Values
{
    [PublicAPI]
    public class HerculesNull : IEquatable<HerculesNull>
    {
        public static readonly HerculesNull Instance = new HerculesNull();

        public override string ToString() => "<null>";

        #region Equality

        public bool Equals(HerculesNull other) => true;

        public override bool Equals(object other)
            => other is HerculesNull;

        public override int GetHashCode() => 0;

        #endregion
    }
}