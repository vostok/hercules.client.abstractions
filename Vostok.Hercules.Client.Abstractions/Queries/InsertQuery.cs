using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Vostok.Hercules.Client.Abstractions.Events;
using Vostok.Hercules.Client.Abstractions.Models;

namespace Vostok.Hercules.Client.Abstractions.Queries
{
    [PublicAPI]
    public class InsertQuery
    {
        public InsertQuery([NotNull] string stream, [NotNull] IList<HerculesEvent> events)
        {
            Stream = stream ?? throw new ArgumentNullException(nameof(stream));
            Events = events ?? throw new ArgumentNullException(nameof(events));
        }

        /// <summary>
        /// Name of the <see cref="StreamType.Base"/> stream to insert to.
        /// </summary>
        [NotNull]
        public string Stream { get; set; }

        /// <summary>
        /// Events to be inserted.
        /// </summary>
        [NotNull]
        public IList<HerculesEvent> Events { get; set; }
    }
}