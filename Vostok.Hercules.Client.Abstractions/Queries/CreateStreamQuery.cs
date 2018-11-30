using System;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Models;

namespace Vostok.Hercules.Client.Abstractions.Queries
{
    [PublicAPI]
    public class CreateStreamQuery
    {
        public CreateStreamQuery([NotNull] StreamDescription description)
        {
            Description = description ?? throw new ArgumentNullException(nameof(description));
        }

        [NotNull]
        public StreamDescription Description { get; set; }
    }
}