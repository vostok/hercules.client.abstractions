using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

// ReSharper disable PossibleInvalidOperationException

namespace Vostok.Hercules.Client.Abstractions.Values
{
    internal class HerculesVector<TValue> : HerculesVector
    {
        private static readonly HerculesValueType? type = HerculesValueTypesMapping.TryMap(typeof(TValue));
        
        public HerculesVector([NotNull] IReadOnlyList<TValue> elements)
        {
            if (type == null)
                HerculesValueTypesMapping.ThrowNotSupportedException(typeof(TValue));
            
            TypedElements = elements ?? throw new ArgumentNullException(nameof(elements));
        }

        [NotNull]
        public IReadOnlyList<TValue> TypedElements { get; }

        public override HerculesValueType ElementType => type.Value;

        public override IEnumerable<HerculesValue> Elements 
            => TypedElements.Select(element => new HerculesValue<TValue>(element));

        public override int Count => TypedElements.Count;
    }
}