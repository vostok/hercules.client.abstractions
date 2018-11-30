using System;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Models;

namespace Vostok.Hercules.Client.Abstractions.Queries
{
    [PublicAPI]
    public class CreateTimelineQuery
    {
        public CreateTimelineQuery([NotNull] TimelineDescription description)
        {
            Description = description ?? throw new ArgumentNullException(nameof(description));
        }

        [NotNull]
        public TimelineDescription Description { get; set; }
    }
}